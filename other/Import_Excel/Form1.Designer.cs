namespace Import_Excel
{
    partial class Form1
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
            this.Data = new System.Windows.Forms.DataGridView();
            this.filename_box = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.key_textbox = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.status_icon = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(12, 90);
            this.Data.Name = "Data";
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.Size = new System.Drawing.Size(230, 348);
            this.Data.TabIndex = 1;
            // 
            // filename_box
            // 
            this.filename_box.Enabled = true;
            this.filename_box.FormattingEnabled = true;
            this.filename_box.Items.AddRange(new object[] {
            "จังหวัด",
            "แขวง",
            "เขต",
            "ถนน"});
            this.filename_box.Location = new System.Drawing.Point(12, 41);
            this.filename_box.Name = "filename_box";
            this.filename_box.Size = new System.Drawing.Size(121, 24);
            this.filename_box.TabIndex = 3;
            this.filename_box.SelectedIndexChanged += new System.EventHandler(this.filename_box_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(322, 232);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(144, 72);
            this.btn.TabIndex = 4;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Visible = false;
            // 
            // key_textbox
            // 
            this.key_textbox.Location = new System.Drawing.Point(322, 62);
            this.key_textbox.Name = "key_textbox";
            this.key_textbox.Size = new System.Drawing.Size(140, 22);
            this.key_textbox.TabIndex = 5;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gold;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gold;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(285, 62);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 31);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(322, 90);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(65, 38);
            this.submit_btn.TabIndex = 4;
            this.submit_btn.Text = "submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // status_icon
            // 
            this.status_icon.BackColor = System.Drawing.SystemColors.Control;
            this.status_icon.ForeColor = System.Drawing.Color.Gold;
            this.status_icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.status_icon.IconColor = System.Drawing.Color.Gold;
            this.status_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.status_icon.IconSize = 31;
            this.status_icon.Location = new System.Drawing.Point(468, 62);
            this.status_icon.Name = "status_icon";
            this.status_icon.Size = new System.Drawing.Size(31, 31);
            this.status_icon.TabIndex = 6;
            this.status_icon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status_icon);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.key_textbox);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.filename_box);
            this.Controls.Add(this.Data);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.ComboBox filename_box;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox key_textbox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button submit_btn;
        private FontAwesome.Sharp.IconPictureBox status_icon;
        private System.Windows.Forms.Label label1;
    }
}

