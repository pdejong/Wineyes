using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wineyes {
    public partial class Form2 : Form {
        private Search.Study m_Study;
        public Search.Image OD {
            get { return lv_ImagesOD.SelectedItems.Count > 0 ? lv_ImagesOD.SelectedItems[0].Tag as Search.Image : null; }
        }
        public Search.Image OS {
            get { return lv_ImagesOS.SelectedItems.Count > 0 ? lv_ImagesOS.SelectedItems[0].Tag as Search.Image : null; }
        }

        public Form2(Search.Study study) {
            InitializeComponent();
            m_Study = study;
        }

     
        private void button1_Click(object sender, EventArgs e) {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e) {
            if (DesignMode) return;
            using (Search.PSearchSvcClient client = new Search.PSearchSvcClient()) {
                Search.Image[] imagesOD = client.FindImages(m_Study.StudyId, "OD");
                Search.Image[] imagesOS = client.FindImages(m_Study.StudyId, "OS");
                lv_ImagesOD.Items.Clear();
                iml_ImagesOD.Images.Clear();
                lv_ImagesOS.Items.Clear();
                iml_ImagesOS.Images.Clear();
                foreach (Search.Image im in imagesOD) {
                    ListViewItem item = new ListViewItem(im.ImageId);
                    item.Tag = im;
                    Image thumbnail = Image.FromStream(client.GetImage(im.ImageId)).GetThumbnailImage(150, 113, null, IntPtr.Zero);
                    iml_ImagesOD.Images.Add(thumbnail);
                    lv_ImagesOD.Items.Add(item);
                    item.ImageIndex = iml_ImagesOD.Images.Count - 1;
                    if (lv_ImagesOD.SelectedItems.Count == 0) item.Selected = true;
                }
                foreach (Search.Image im in imagesOS) {
                    ListViewItem item = new ListViewItem(im.ImageId);
                    item.Tag = im;
                    Image thumbnail = Image.FromStream(client.GetImage(im.ImageId)).GetThumbnailImage(150, 113, null, IntPtr.Zero);
                    iml_ImagesOS.Images.Add(thumbnail);
                    lv_ImagesOS.Items.Add(item);
                    item.ImageIndex = iml_ImagesOS.Images.Count - 1;
                    if (lv_ImagesOS.SelectedItems.Count == 0) item.Selected = true;
                }
                if (lv_ImagesOD.Items.Count == 1 && lv_ImagesOS.Items.Count == 1) button1_Click(sender, e);
            }
        }

        private void lv_ImagesOD_SelectedIndexChanged(object sender, EventArgs e) {
            using (Search.PSearchSvcClient client = new Search.PSearchSvcClient()) {
                foreach (ListViewItem item in ((ListView)sender).Items) {
                    if(item.Selected)
                        pictureBox1.Image = Image.FromStream(client.GetImage(((Search.Image)item.Tag).ImageId));
                }
            }
        }

        private void pictureBox1_Resize(object sender, EventArgs e) {
            
        }
    }
}
