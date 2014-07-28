namespace Wineyes {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.txt_PatientName = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.txt_PatientId = new System.Windows.Forms.TextBox();
            this.btn_SearchKeratometry = new System.Windows.Forms.Button();
            this.dtp_StudyDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Referring = new System.Windows.Forms.TextBox();
            this.txt_AccessionNumber = new System.Windows.Forms.TextBox();
            this.nud_Sph_Dx = new System.Windows.Forms.NumericUpDown();
            this.nud_Cyl_Dx = new System.Windows.Forms.NumericUpDown();
            this.nud_Ax_Dx = new System.Windows.Forms.NumericUpDown();
            this.nud_Ax_Sx = new System.Windows.Forms.NumericUpDown();
            this.nud_Cyl_Sx = new System.Windows.Forms.NumericUpDown();
            this.nud_Sph_Sx = new System.Windows.Forms.NumericUpDown();
            this.btn_SetRefraction = new System.Windows.Forms.Button();
            this.txt_OSIrisDiameter = new System.Windows.Forms.TextBox();
            this.txt_ODIrisDiameter = new System.Windows.Forms.TextBox();
            this.txt_OSAx = new System.Windows.Forms.TextBox();
            this.txt_OSR2mm = new System.Windows.Forms.TextBox();
            this.txt_OSR1mm = new System.Windows.Forms.TextBox();
            this.txt_OSR2D = new System.Windows.Forms.TextBox();
            this.txt_OSR1D = new System.Windows.Forms.TextBox();
            this.txt_ODAx = new System.Windows.Forms.TextBox();
            this.txt_ODR2mm = new System.Windows.Forms.TextBox();
            this.txt_ODR1mm = new System.Windows.Forms.TextBox();
            this.txt_ODR2D = new System.Windows.Forms.TextBox();
            this.txt_ODR1D = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sph_Dx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cyl_Dx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ax_Dx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ax_Sx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cyl_Sx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sph_Sx)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PatientName
            // 
            this.txt_PatientName.BackColor = System.Drawing.Color.Khaki;
            this.txt_PatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientName.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_PatientName.Location = new System.Drawing.Point(162, 103);
            this.txt_PatientName.Name = "txt_PatientName";
            this.txt_PatientName.Size = new System.Drawing.Size(184, 20);
            this.txt_PatientName.TabIndex = 0;
            this.txt_PatientName.Text = "Tronchini Peter";
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.Color.Khaki;
            this.txt_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gender.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_Gender.Location = new System.Drawing.Point(346, 103);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(15, 20);
            this.txt_Gender.TabIndex = 1;
            this.txt_Gender.Text = "M";
            this.txt_Gender.Visible = false;
            // 
            // txt_PatientId
            // 
            this.txt_PatientId.BackColor = System.Drawing.Color.Khaki;
            this.txt_PatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientId.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_PatientId.Location = new System.Drawing.Point(579, 102);
            this.txt_PatientId.Name = "txt_PatientId";
            this.txt_PatientId.Size = new System.Drawing.Size(176, 20);
            this.txt_PatientId.TabIndex = 3;
            this.txt_PatientId.Text = "PATID";
            this.txt_PatientId.Visible = false;
            // 
            // btn_SearchKeratometry
            // 
            this.btn_SearchKeratometry.Location = new System.Drawing.Point(743, 128);
            this.btn_SearchKeratometry.Name = "btn_SearchKeratometry";
            this.btn_SearchKeratometry.Size = new System.Drawing.Size(178, 20);
            this.btn_SearchKeratometry.TabIndex = 4;
            this.btn_SearchKeratometry.Text = "Interfaccia con strumenti esterni";
            this.btn_SearchKeratometry.UseVisualStyleBackColor = true;
            this.btn_SearchKeratometry.Click += new System.EventHandler(this.btn_SearchKeratometry_Click);
            // 
            // dtp_StudyDate
            // 
            this.dtp_StudyDate.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dtp_StudyDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_StudyDate.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dtp_StudyDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_StudyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StudyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StudyDate.Location = new System.Drawing.Point(244, 126);
            this.dtp_StudyDate.Name = "dtp_StudyDate";
            this.dtp_StudyDate.Size = new System.Drawing.Size(126, 20);
            this.dtp_StudyDate.TabIndex = 5;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dtp_BirthDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_BirthDate.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dtp_BirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BirthDate.Location = new System.Drawing.Point(367, 103);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(206, 20);
            this.dtp_BirthDate.TabIndex = 6;
            this.dtp_BirthDate.Value = new System.DateTime(1956, 1, 1, 0, 0, 0, 0);
            this.dtp_BirthDate.Visible = false;
            // 
            // txt_Referring
            // 
            this.txt_Referring.BackColor = System.Drawing.Color.Khaki;
            this.txt_Referring.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Referring.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_Referring.Location = new System.Drawing.Point(208, 634);
            this.txt_Referring.Name = "txt_Referring";
            this.txt_Referring.Size = new System.Drawing.Size(162, 20);
            this.txt_Referring.TabIndex = 7;
            this.txt_Referring.Text = "Rosati Filippo";
            // 
            // txt_AccessionNumber
            // 
            this.txt_AccessionNumber.BackColor = System.Drawing.Color.Khaki;
            this.txt_AccessionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessionNumber.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_AccessionNumber.Location = new System.Drawing.Point(367, 128);
            this.txt_AccessionNumber.Name = "txt_AccessionNumber";
            this.txt_AccessionNumber.Size = new System.Drawing.Size(131, 20);
            this.txt_AccessionNumber.TabIndex = 8;
            this.txt_AccessionNumber.Text = "AN001";
            // 
            // nud_Sph_Dx
            // 
            this.nud_Sph_Dx.BackColor = System.Drawing.Color.Khaki;
            this.nud_Sph_Dx.DecimalPlaces = 2;
            this.nud_Sph_Dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Sph_Dx.ForeColor = System.Drawing.Color.DarkRed;
            this.nud_Sph_Dx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Sph_Dx.Location = new System.Drawing.Point(334, 498);
            this.nud_Sph_Dx.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Sph_Dx.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nud_Sph_Dx.Name = "nud_Sph_Dx";
            this.nud_Sph_Dx.Size = new System.Drawing.Size(53, 20);
            this.nud_Sph_Dx.TabIndex = 9;
            this.nud_Sph_Dx.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_Cyl_Dx
            // 
            this.nud_Cyl_Dx.BackColor = System.Drawing.Color.Khaki;
            this.nud_Cyl_Dx.DecimalPlaces = 2;
            this.nud_Cyl_Dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Cyl_Dx.ForeColor = System.Drawing.Color.DarkRed;
            this.nud_Cyl_Dx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Cyl_Dx.Location = new System.Drawing.Point(393, 498);
            this.nud_Cyl_Dx.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Cyl_Dx.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nud_Cyl_Dx.Name = "nud_Cyl_Dx";
            this.nud_Cyl_Dx.Size = new System.Drawing.Size(44, 20);
            this.nud_Cyl_Dx.TabIndex = 10;
            this.nud_Cyl_Dx.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // nud_Ax_Dx
            // 
            this.nud_Ax_Dx.BackColor = System.Drawing.Color.Khaki;
            this.nud_Ax_Dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Ax_Dx.ForeColor = System.Drawing.Color.DarkRed;
            this.nud_Ax_Dx.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Ax_Dx.Location = new System.Drawing.Point(441, 498);
            this.nud_Ax_Dx.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nud_Ax_Dx.Name = "nud_Ax_Dx";
            this.nud_Ax_Dx.Size = new System.Drawing.Size(37, 20);
            this.nud_Ax_Dx.TabIndex = 11;
            this.nud_Ax_Dx.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nud_Ax_Sx
            // 
            this.nud_Ax_Sx.BackColor = System.Drawing.Color.Khaki;
            this.nud_Ax_Sx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Ax_Sx.ForeColor = System.Drawing.Color.DarkRed;
            this.nud_Ax_Sx.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Ax_Sx.Location = new System.Drawing.Point(791, 498);
            this.nud_Ax_Sx.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nud_Ax_Sx.Name = "nud_Ax_Sx";
            this.nud_Ax_Sx.Size = new System.Drawing.Size(37, 20);
            this.nud_Ax_Sx.TabIndex = 14;
            this.nud_Ax_Sx.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nud_Cyl_Sx
            // 
            this.nud_Cyl_Sx.BackColor = System.Drawing.Color.Khaki;
            this.nud_Cyl_Sx.DecimalPlaces = 2;
            this.nud_Cyl_Sx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Cyl_Sx.ForeColor = System.Drawing.Color.DarkRed;
            this.nud_Cyl_Sx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Cyl_Sx.Location = new System.Drawing.Point(743, 498);
            this.nud_Cyl_Sx.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Cyl_Sx.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nud_Cyl_Sx.Name = "nud_Cyl_Sx";
            this.nud_Cyl_Sx.Size = new System.Drawing.Size(44, 20);
            this.nud_Cyl_Sx.TabIndex = 13;
            this.nud_Cyl_Sx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_Sph_Sx
            // 
            this.nud_Sph_Sx.BackColor = System.Drawing.Color.Khaki;
            this.nud_Sph_Sx.DecimalPlaces = 2;
            this.nud_Sph_Sx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Sph_Sx.ForeColor = System.Drawing.Color.DarkRed;
            this.nud_Sph_Sx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Sph_Sx.Location = new System.Drawing.Point(684, 498);
            this.nud_Sph_Sx.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Sph_Sx.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nud_Sph_Sx.Name = "nud_Sph_Sx";
            this.nud_Sph_Sx.Size = new System.Drawing.Size(53, 20);
            this.nud_Sph_Sx.TabIndex = 12;
            this.nud_Sph_Sx.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // btn_SetRefraction
            // 
            this.btn_SetRefraction.Location = new System.Drawing.Point(743, 524);
            this.btn_SetRefraction.Name = "btn_SetRefraction";
            this.btn_SetRefraction.Size = new System.Drawing.Size(178, 19);
            this.btn_SetRefraction.TabIndex = 15;
            this.btn_SetRefraction.Text = "Set Refraction";
            this.btn_SetRefraction.UseVisualStyleBackColor = true;
            this.btn_SetRefraction.Click += new System.EventHandler(this.btn_SetRefraction_Click);
            // 
            // txt_OSIrisDiameter
            // 
            this.txt_OSIrisDiameter.Location = new System.Drawing.Point(887, 261);
            this.txt_OSIrisDiameter.Name = "txt_OSIrisDiameter";
            this.txt_OSIrisDiameter.Size = new System.Drawing.Size(34, 20);
            this.txt_OSIrisDiameter.TabIndex = 34;
            // 
            // txt_ODIrisDiameter
            // 
            this.txt_ODIrisDiameter.Location = new System.Drawing.Point(695, 261);
            this.txt_ODIrisDiameter.Name = "txt_ODIrisDiameter";
            this.txt_ODIrisDiameter.Size = new System.Drawing.Size(38, 20);
            this.txt_ODIrisDiameter.TabIndex = 32;
            // 
            // txt_OSAx
            // 
            this.txt_OSAx.Location = new System.Drawing.Point(841, 261);
            this.txt_OSAx.Name = "txt_OSAx";
            this.txt_OSAx.Size = new System.Drawing.Size(36, 20);
            this.txt_OSAx.TabIndex = 29;
            // 
            // txt_OSR2mm
            // 
            this.txt_OSR2mm.Location = new System.Drawing.Point(742, 283);
            this.txt_OSR2mm.Name = "txt_OSR2mm";
            this.txt_OSR2mm.Size = new System.Drawing.Size(45, 20);
            this.txt_OSR2mm.TabIndex = 28;
            // 
            // txt_OSR1mm
            // 
            this.txt_OSR1mm.Location = new System.Drawing.Point(743, 261);
            this.txt_OSR1mm.Name = "txt_OSR1mm";
            this.txt_OSR1mm.Size = new System.Drawing.Size(44, 20);
            this.txt_OSR1mm.TabIndex = 27;
            // 
            // txt_OSR2D
            // 
            this.txt_OSR2D.Location = new System.Drawing.Point(794, 284);
            this.txt_OSR2D.Name = "txt_OSR2D";
            this.txt_OSR2D.Size = new System.Drawing.Size(41, 20);
            this.txt_OSR2D.TabIndex = 26;
            // 
            // txt_OSR1D
            // 
            this.txt_OSR1D.Location = new System.Drawing.Point(794, 261);
            this.txt_OSR1D.Name = "txt_OSR1D";
            this.txt_OSR1D.Size = new System.Drawing.Size(41, 20);
            this.txt_OSR1D.TabIndex = 25;
            // 
            // txt_ODAx
            // 
            this.txt_ODAx.Location = new System.Drawing.Point(661, 261);
            this.txt_ODAx.Name = "txt_ODAx";
            this.txt_ODAx.Size = new System.Drawing.Size(28, 20);
            this.txt_ODAx.TabIndex = 23;
            // 
            // txt_ODR2mm
            // 
            this.txt_ODR2mm.Location = new System.Drawing.Point(559, 284);
            this.txt_ODR2mm.Name = "txt_ODR2mm";
            this.txt_ODR2mm.Size = new System.Drawing.Size(45, 20);
            this.txt_ODR2mm.TabIndex = 22;
            // 
            // txt_ODR1mm
            // 
            this.txt_ODR1mm.Location = new System.Drawing.Point(560, 261);
            this.txt_ODR1mm.Name = "txt_ODR1mm";
            this.txt_ODR1mm.Size = new System.Drawing.Size(44, 20);
            this.txt_ODR1mm.TabIndex = 21;
            // 
            // txt_ODR2D
            // 
            this.txt_ODR2D.Location = new System.Drawing.Point(608, 283);
            this.txt_ODR2D.Name = "txt_ODR2D";
            this.txt_ODR2D.Size = new System.Drawing.Size(44, 20);
            this.txt_ODR2D.TabIndex = 20;
            // 
            // txt_ODR1D
            // 
            this.txt_ODR1D.Location = new System.Drawing.Point(608, 261);
            this.txt_ODR1D.Name = "txt_ODR1D";
            this.txt_ODR1D.Size = new System.Drawing.Size(47, 20);
            this.txt_ODR1D.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wineyes.Properties.Resources.img_Background;
            this.ClientSize = new System.Drawing.Size(1026, 695);
            this.Controls.Add(this.txt_OSIrisDiameter);
            this.Controls.Add(this.txt_ODIrisDiameter);
            this.Controls.Add(this.txt_OSAx);
            this.Controls.Add(this.txt_OSR2mm);
            this.Controls.Add(this.txt_OSR1mm);
            this.Controls.Add(this.txt_OSR2D);
            this.Controls.Add(this.txt_OSR1D);
            this.Controls.Add(this.txt_ODAx);
            this.Controls.Add(this.txt_ODR2mm);
            this.Controls.Add(this.txt_ODR1mm);
            this.Controls.Add(this.txt_ODR2D);
            this.Controls.Add(this.txt_ODR1D);
            this.Controls.Add(this.btn_SetRefraction);
            this.Controls.Add(this.nud_Ax_Sx);
            this.Controls.Add(this.nud_Cyl_Sx);
            this.Controls.Add(this.nud_Sph_Sx);
            this.Controls.Add(this.nud_Ax_Dx);
            this.Controls.Add(this.nud_Cyl_Dx);
            this.Controls.Add(this.nud_Sph_Dx);
            this.Controls.Add(this.txt_AccessionNumber);
            this.Controls.Add(this.txt_Referring);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.dtp_StudyDate);
            this.Controls.Add(this.btn_SearchKeratometry);
            this.Controls.Add(this.txt_PatientId);
            this.Controls.Add(this.txt_Gender);
            this.Controls.Add(this.txt_PatientName);
            this.MaximumSize = new System.Drawing.Size(1042, 733);
            this.MinimumSize = new System.Drawing.Size(1042, 733);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sph_Dx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cyl_Dx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ax_Dx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ax_Sx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cyl_Sx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sph_Sx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PatientName;
        private System.Windows.Forms.TextBox txt_Gender;
        private System.Windows.Forms.TextBox txt_PatientId;
        private System.Windows.Forms.Button btn_SearchKeratometry;
        private System.Windows.Forms.DateTimePicker dtp_StudyDate;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.TextBox txt_Referring;
        private System.Windows.Forms.TextBox txt_AccessionNumber;
        private System.Windows.Forms.NumericUpDown nud_Sph_Dx;
        private System.Windows.Forms.NumericUpDown nud_Cyl_Dx;
        private System.Windows.Forms.NumericUpDown nud_Ax_Dx;
        private System.Windows.Forms.NumericUpDown nud_Ax_Sx;
        private System.Windows.Forms.NumericUpDown nud_Cyl_Sx;
        private System.Windows.Forms.NumericUpDown nud_Sph_Sx;
        private System.Windows.Forms.Button btn_SetRefraction;
        private System.Windows.Forms.TextBox txt_OSIrisDiameter;
        private System.Windows.Forms.TextBox txt_ODIrisDiameter;
        private System.Windows.Forms.TextBox txt_OSAx;
        private System.Windows.Forms.TextBox txt_OSR2mm;
        private System.Windows.Forms.TextBox txt_OSR1mm;
        private System.Windows.Forms.TextBox txt_OSR2D;
        private System.Windows.Forms.TextBox txt_OSR1D;
        private System.Windows.Forms.TextBox txt_ODAx;
        private System.Windows.Forms.TextBox txt_ODR2mm;
        private System.Windows.Forms.TextBox txt_ODR1mm;
        private System.Windows.Forms.TextBox txt_ODR2D;
        private System.Windows.Forms.TextBox txt_ODR1D;
    }
}

