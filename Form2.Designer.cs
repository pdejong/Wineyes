namespace Wineyes {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lv_ImagesOS = new System.Windows.Forms.ListView();
            this.iml_ImagesOS = new System.Windows.Forms.ImageList(this.components);
            this.lv_ImagesOD = new System.Windows.Forms.ListView();
            this.iml_ImagesOD = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_ImagesOS
            // 
            this.lv_ImagesOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_ImagesOS.HideSelection = false;
            this.lv_ImagesOS.LargeImageList = this.iml_ImagesOS;
            this.lv_ImagesOS.Location = new System.Drawing.Point(0, 77);
            this.lv_ImagesOS.MultiSelect = false;
            this.lv_ImagesOS.Name = "lv_ImagesOS";
            this.lv_ImagesOS.Size = new System.Drawing.Size(509, 77);
            this.lv_ImagesOS.TabIndex = 18;
            this.lv_ImagesOS.TileSize = new System.Drawing.Size(64, 64);
            this.lv_ImagesOS.UseCompatibleStateImageBehavior = false;
            this.lv_ImagesOS.View = System.Windows.Forms.View.Tile;
            // 
            // iml_ImagesOS
            // 
            this.iml_ImagesOS.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.iml_ImagesOS.ImageSize = new System.Drawing.Size(64, 64);
            this.iml_ImagesOS.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lv_ImagesOD
            // 
            this.lv_ImagesOD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_ImagesOD.HideSelection = false;
            this.lv_ImagesOD.LargeImageList = this.iml_ImagesOD;
            this.lv_ImagesOD.Location = new System.Drawing.Point(0, 0);
            this.lv_ImagesOD.MultiSelect = false;
            this.lv_ImagesOD.Name = "lv_ImagesOD";
            this.lv_ImagesOD.Size = new System.Drawing.Size(509, 77);
            this.lv_ImagesOD.TabIndex = 17;
            this.lv_ImagesOD.TileSize = new System.Drawing.Size(64, 64);
            this.lv_ImagesOD.UseCompatibleStateImageBehavior = false;
            this.lv_ImagesOD.View = System.Windows.Forms.View.Tile;
            this.lv_ImagesOD.SelectedIndexChanged += new System.EventHandler(this.lv_ImagesOD_SelectedIndexChanged);
            // 
            // iml_ImagesOD
            // 
            this.iml_ImagesOD.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.iml_ImagesOD.ImageSize = new System.Drawing.Size(64, 64);
            this.iml_ImagesOD.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "OD";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "OS";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(349, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(430, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 41);
            this.panel1.TabIndex = 24;
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(509, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_ImagesOS);
            this.Controls.Add(this.lv_ImagesOD);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_ImagesOS;
        private System.Windows.Forms.ListView lv_ImagesOD;
        private System.Windows.Forms.ImageList iml_ImagesOD;
        private System.Windows.Forms.ImageList iml_ImagesOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}