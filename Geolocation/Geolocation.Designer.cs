namespace WindowsFormsApp1.Forms
{
    partial class Geolocation
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.Analysis = new FontAwesome.Sharp.IconButton();
            this.reset_btn = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import_btn = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Panel();
            this.minimize_btn = new FontAwesome.Sharp.IconPictureBox();
            this.close_btn = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // pathfile_box
            // 
            this.pathfile_box.Location = new System.Drawing.Point(50, 50);
            this.pathfile_box.Name = "pathfile_box";
            this.pathfile_box.ReadOnly = true;
            this.pathfile_box.Size = new System.Drawing.Size(417, 22);
            this.pathfile_box.TabIndex = 1;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(15, 88);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.Size = new System.Drawing.Size(188, 350);
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
            this.Analysis.Location = new System.Drawing.Point(584, 45);
            this.Analysis.Name = "Analysis";
            this.Analysis.Size = new System.Drawing.Size(105, 32);
            this.Analysis.TabIndex = 3;
            this.Analysis.Text = "Analysis";
            this.Analysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Analysis.UseVisualStyleBackColor = true;
            this.Analysis.Click += new System.EventHandler(this.Analysis_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.reset_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.reset_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reset_btn.IconSize = 25;
            this.reset_btn.Location = new System.Drawing.Point(695, 45);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(105, 32);
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
            this.lat,
            this.lon});
            this.dgvData.Location = new System.Drawing.Point(236, 88);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(552, 350);
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
            // lat
            // 
            this.lat.HeaderText = "Latitude";
            this.lat.MinimumWidth = 6;
            this.lat.Name = "lat";
            this.lat.Width = 125;
            // 
            // lon
            // 
            this.lon.HeaderText = "Longitude";
            this.lon.MinimumWidth = 6;
            this.lon.Name = "lon";
            this.lon.ReadOnly = true;
            this.lon.Width = 125;
            // 
            // import_btn
            // 
            this.import_btn.FlatAppearance.BorderSize = 0;
            this.import_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.import_btn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.import_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.import_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.import_btn.IconSize = 25;
            this.import_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.import_btn.Location = new System.Drawing.Point(473, 45);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(105, 32);
            this.import_btn.TabIndex = 7;
            this.import_btn.Text = "Import";
            this.import_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(0, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(116, 25);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Geolocation";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.title.Controls.Add(this.lblTitleChildForm);
            this.title.Controls.Add(this.minimize_btn);
            this.title.Controls.Add(this.close_btn);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 35);
            this.title.TabIndex = 8;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimize_btn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimize_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.minimize_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize_btn.IconSize = 35;
            this.minimize_btn.Location = new System.Drawing.Point(730, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(35, 35);
            this.minimize_btn.TabIndex = 0;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.close_btn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.close_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.close_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_btn.IconSize = 35;
            this.close_btn.Location = new System.Drawing.Point(765, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(35, 35);
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Geolocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.Analysis);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.pathfile_box);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Geolocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geolocation";
            this.Load += new System.EventHandler(this.Geolocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathfile_box;
        private System.Windows.Forms.TextBox tbData;
        private FontAwesome.Sharp.IconButton Analysis;
        private FontAwesome.Sharp.IconButton reset_btn;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn lon;
        private FontAwesome.Sharp.IconButton import_btn;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel title;
        private FontAwesome.Sharp.IconPictureBox minimize_btn;
        private FontAwesome.Sharp.IconPictureBox close_btn;
    }
}