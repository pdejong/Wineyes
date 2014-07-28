using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace Wineyes {
    /// <summary>
    /// (c) 2014 Piet de Jong
    /// </summary>
    public partial class Form1 : Form {
        private string m_Executable;

        public Form1() {
            InitializeComponent();
        }

        private void btn_SetRefraction_Click(object sender, EventArgs e) {
            using (Create.HttpCreateClient client = new Create.HttpCreateClient()) {
                string[] name = txt_PatientName.Text.Split(' ');
                try {
                    client.CreatePatient("WinEyes", txt_PatientId.Text, name.Length > 1 ? name[1] : string.Empty, name.Length > 0 ? name[0] : string.Empty,
                                    "M".Equals(txt_Gender.Text) ? "M" : "F", dtp_BirthDate.Value);
                }
                catch {
                    MessageBox.Show("Patient already exists..");
                }
                try {
                    client.ScheduleProcedure(txt_PatientId.Text, dtp_StudyDate.Value, txt_AccessionNumber.Text, txt_Referring.Text, "");
                }
                catch {
                    MessageBox.Show(string.Format("Patient [{0}] not found..", txt_PatientId.Text));
                }
                try {
                    client.AddRefraction(txt_PatientId.Text, (float)nud_Sph_Dx.Value, (float)nud_Cyl_Dx.Value, (int)nud_Ax_Dx.Value, string.Empty, string.Empty,
                                                            (float)nud_Sph_Sx.Value, (float)nud_Cyl_Sx.Value, (int)nud_Ax_Sx.Value, string.Empty, string.Empty, 0, 0);
                }
                catch {
                    MessageBox.Show(string.Format("Patient [{0}] not found..", txt_PatientId.Text));
                }
                Process.Start(m_Executable, string.Format("AccessionNumber=\\\"{0}\\\"", txt_AccessionNumber.Text));

            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\CSO\Phoenix", RegistryKeyPermissionCheck.ReadSubTree, System.Security.AccessControl.RegistryRights.ReadKey);
            if (key != null)
                try {
                    string ID = key.GetValue("InstallDir").ToString();
                    string Executable = key.GetValue("Executable").ToString();
                    m_Executable = Path.Combine(ID, Executable + ".exe");
                }
                catch (Exception ex) { }
            if (!File.Exists(m_Executable)) {
                //if (args.Length > 1 && File.Exists(args[0])) m_Executable = args[1];
                //else {
                string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
                if (File.Exists(location = Path.Combine(Path.GetDirectoryName(location), "Phoenix.exe")))
                    m_Executable = location;
                else {
                    MessageBox.Show(this, "Phoenix non trovato!");
                }
            }
        }

        private void btn_SearchKeratometry_Click(object sender, EventArgs e) {
            using (Search.PSearchSvcClient client = new Search.PSearchSvcClient()) {
                string[] name = txt_PatientName.Text.Split(' ');
                Search.Patient[] patients = client.SearchPatients(name.Length > 1 ? name[1] : string.Empty, name.Length > 0 ? name[0] : string.Empty);
                if (patients.Length == 0) {
                    MessageBox.Show("Paziente non trovato!");
                    return;
                }
                List<Search.Study> studies = new List<Search.Study>(client.FindStudies(patients[0].PatientId));
                //List<Search.Study> studies = new List<Search.Study>(client.FindStudies(txt_PatientId.Text));
                studies.RemoveAll(s => { return !(s.Device.Equals("Scheimpflug Camera") || s.Device.Equals("Keratoscope")); });
                studies.Sort((a, b) => { return b.StudyDate.CompareTo(a.StudyDate); });
                if (studies.Count == 0) {
                    MessageBox.Show("Nessun esame topografico trovato!");
                    return;
                }
                using (Form2 frm = new Form2(studies[0])) {
                    if (frm.ShowDialog() == DialogResult.OK) {
                        if (frm.OD != null) {
                            Data bcsOD = new Data(frm.OD, client.GetBCS(frm.OD.ImageId));
                            //txt_ODPupilDiameter.Text = bcsOD.PupilDiameter.ToString("0.00");
                            txt_ODIrisDiameter.Text = bcsOD.IrisDiameter.ToString("0.00");
                            txt_ODR1D.Text = bcsOD.Flat.Power.ToString("0.00");
                            txt_ODR1mm.Text = bcsOD.Flat.Radius.ToString("0.00");
                            txt_ODR2D.Text = bcsOD.Steep.Power.ToString("0.00");
                            txt_ODR2mm.Text = bcsOD.Steep.Radius.ToString("0.00");
                            //txt_ODAvg.Text = ((bcsOD.Flat.Radius + bcsOD.Steep.Radius) / 2).ToString("0.00");
                            txt_ODAx.Text = bcsOD.Flat.Angle.ToString("0");
                        }
                        if (frm.OS != null) {
                            Data bcsOS = new Data(frm.OS, client.GetBCS(frm.OS.ImageId));
                            //txt_OSPupilDiameter.Text = bcsOS.PupilDiameter.ToString("0.00");
                            txt_OSIrisDiameter.Text = bcsOS.IrisDiameter.ToString("0.00");
                            txt_OSR1D.Text = bcsOS.Flat.Power.ToString("0.00");
                            txt_OSR1mm.Text = bcsOS.Flat.Radius.ToString("0.00");
                            txt_OSR2D.Text = bcsOS.Steep.Power.ToString("0.00");
                            txt_OSR2mm.Text = bcsOS.Steep.Radius.ToString("0.00");
                            //txt_OSAvg.Text = ((bcsOS.Flat.Radius + bcsOS.Steep.Radius) / 2).ToString("0.00");
                            txt_OSAx.Text = bcsOS.Flat.Angle.ToString("0");
                        }
                    }
                }

            }
        }
    }
}
