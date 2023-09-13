﻿namespace WindowsFormsApp1.Forms
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
            this.browse_btn = new FontAwesome.Sharp.IconPictureBox();
            this.load_btn = new FontAwesome.Sharp.IconPictureBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.Analysis = new FontAwesome.Sharp.IconButton();
            this.lat_box = new System.Windows.Forms.TextBox();
            this.lon_box = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.reset_btn = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.browse_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
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
            // browse_btn
            // 
            this.browse_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.browse_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.browse_btn.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.browse_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.browse_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.browse_btn.Location = new System.Drawing.Point(395, 12);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(32, 32);
            this.browse_btn.TabIndex = 2;
            this.browse_btn.TabStop = false;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.load_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.load_btn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.load_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.load_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.load_btn.Location = new System.Drawing.Point(433, 12);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(32, 32);
            this.load_btn.TabIndex = 2;
            this.load_btn.TabStop = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(15, 53);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.Size = new System.Drawing.Size(216, 335);
            this.tbData.TabIndex = 1;
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
            this.Analysis.Click += new System.EventHandler(this.Analysis_Click);
            // 
            // lat_box
            // 
            this.lat_box.Location = new System.Drawing.Point(490, 76);
            this.lat_box.Name = "lat_box";
            this.lat_box.ReadOnly = true;
            this.lat_box.Size = new System.Drawing.Size(144, 22);
            this.lat_box.TabIndex = 4;
            // 
            // lon_box
            // 
            this.lon_box.Location = new System.Drawing.Point(490, 151);
            this.lon_box.Name = "lon_box";
            this.lon_box.ReadOnly = true;
            this.lon_box.Size = new System.Drawing.Size(144, 22);
            this.lon_box.TabIndex = 4;
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
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.text,
            this.key,
            this.lon});
            this.dgvData.Location = new System.Drawing.Point(241, 53);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(240, 335);
            this.dgvData.TabIndex = 6;
            // 
            // text
            // 
            this.text.HeaderText = "Text";
            this.text.MinimumWidth = 6;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Width = 125;
            // 
            // key
            // 
            this.key.HeaderText = "key";
            this.key.MinimumWidth = 6;
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.Width = 125;
            // 
            // lon
            // 
            this.lon.HeaderText = "Longtitude";
            this.lon.MinimumWidth = 6;
            this.lon.Name = "lon";
            this.lon.ReadOnly = true;
            this.lon.Width = 125;
            // 
            // FormExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(664, 400);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.lon_box);
            this.Controls.Add(this.lat_box);
            this.Controls.Add(this.Analysis);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.pathfile_box);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExtractor";
            this.Text = "Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.browse_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathfile_box;
        private FontAwesome.Sharp.IconPictureBox browse_btn;
        private FontAwesome.Sharp.IconPictureBox load_btn;
        private System.Windows.Forms.TextBox tbData;
        private FontAwesome.Sharp.IconButton Analysis;
        private System.Windows.Forms.TextBox lat_box;
        private System.Windows.Forms.TextBox lon_box;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label longitude;
        private FontAwesome.Sharp.IconButton reset_btn;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn lon;
    }
}