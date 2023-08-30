namespace WindowsFormsApp1.Forms
{
    partial class FormExtractor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pathfile_box = new System.Windows.Forms.TextBox();
            this.import = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.input_box = new System.Windows.Forms.TextBox();
            this.Analysis = new FontAwesome.Sharp.IconButton();
            this.lat_box = new System.Windows.Forms.TextBox();
            this.lon_box = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.reset_btn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // pathfile_box
            // 
            this.pathfile_box.Location = new System.Drawing.Point(50, 18);
            this.pathfile_box.Name = "pathfile_box";
            this.pathfile_box.ReadOnly = true;
            this.pathfile_box.Size = new System.Drawing.Size(339, 22);
            this.pathfile_box.TabIndex = 1;
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.import.ForeColor = System.Drawing.Color.Gainsboro;
            this.import.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.import.IconColor = System.Drawing.Color.Gainsboro;
            this.import.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.import.Location = new System.Drawing.Point(395, 12);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(32, 32);
            this.import.TabIndex = 2;
            this.import.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(433, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(15, 53);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.ReadOnly = true;
            this.input_box.Size = new System.Drawing.Size(450, 335);
            this.input_box.TabIndex = 1;
            // 
            // Analysis
            // 
            this.Analysis.FlatAppearance.BorderSize = 0;
            this.Analysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Analysis.ForeColor = System.Drawing.Color.Gainsboro;
            this.Analysis.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.Analysis.IconColor = System.Drawing.Color.Gainsboro;
            this.Analysis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Analysis.IconSize = 25;
            this.Analysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Analysis.Location = new System.Drawing.Point(490, 13);
            this.Analysis.Name = "Analysis";
            this.Analysis.Size = new System.Drawing.Size(120, 31);
            this.Analysis.TabIndex = 3;
            this.Analysis.Text = "Analysis";
            this.Analysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Analysis.UseVisualStyleBackColor = true;
            // 
            // lat_box
            // 
            this.lat_box.Location = new System.Drawing.Point(490, 76);
            this.lat_box.Name = "lat_box";
            this.lat_box.ReadOnly = true;
            this.lat_box.Size = new System.Drawing.Size(144, 22);
            this.lat_box.TabIndex = 4;
            this.lat_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lon_box
            // 
            this.lon_box.Location = new System.Drawing.Point(490, 151);
            this.lon_box.Name = "lon_box";
            this.lon_box.ReadOnly = true;
            this.lon_box.Size = new System.Drawing.Size(144, 22);
            this.lon_box.TabIndex = 4;
            this.lon_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.ForeColor = System.Drawing.Color.Gainsboro;
            this.latitude.Location = new System.Drawing.Point(487, 57);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(57, 16);
            this.latitude.TabIndex = 0;
            this.latitude.Text = "Latitude:";
            // 
            // longitude
            // 
            this.longitude.AutoSize = true;
            this.longitude.ForeColor = System.Drawing.Color.Gainsboro;
            this.longitude.Location = new System.Drawing.Point(487, 132);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(69, 16);
            this.longitude.TabIndex = 0;
            this.longitude.Text = "Longitude:";
            // 
            // reset_btn
            // 
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.reset_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reset_btn.IconSize = 36;
            this.reset_btn.Location = new System.Drawing.Point(530, 337);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(104, 51);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Reset";
            this.reset_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reset_btn.UseVisualStyleBackColor = true;
            // 
            // FormExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(664, 400);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.lon_box);
            this.Controls.Add(this.lat_box);
            this.Controls.Add(this.Analysis);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.import);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.pathfile_box);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExtractor";
            this.Text = "Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathfile_box;
        private FontAwesome.Sharp.IconPictureBox import;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox input_box;
        private FontAwesome.Sharp.IconButton Analysis;
        private System.Windows.Forms.TextBox lat_box;
        private System.Windows.Forms.TextBox lon_box;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label longitude;
        private FontAwesome.Sharp.IconButton reset_btn;
    }
}