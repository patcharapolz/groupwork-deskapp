namespace WindowsFormsApp1
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logo_box = new System.Windows.Forms.PictureBox();
            this.config_btn = new FontAwesome.Sharp.IconButton();
            this.extractor_btn = new FontAwesome.Sharp.IconButton();
            this.help_btn = new FontAwesome.Sharp.IconButton();
            this.title = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.minimize_btn = new FontAwesome.Sharp.IconPictureBox();
            this.close_btn = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.status_icon = new FontAwesome.Sharp.IconPictureBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.redeem_box = new System.Windows.Forms.TextBox();
            this.code_lb = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).BeginInit();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.logo_box);
            this.panelMenu.Controls.Add(this.config_btn);
            this.panelMenu.Controls.Add(this.extractor_btn);
            this.panelMenu.Controls.Add(this.help_btn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(136, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // logo_box
            // 
            this.logo_box.Image = ((System.Drawing.Image)(resources.GetObject("logo_box.Image")));
            this.logo_box.Location = new System.Drawing.Point(0, 0);
            this.logo_box.Name = "logo_box";
            this.logo_box.Size = new System.Drawing.Size(136, 136);
            this.logo_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_box.TabIndex = 6;
            this.logo_box.TabStop = false;
            this.logo_box.Click += new System.EventHandler(this.logo_box_Click);
            // 
            // config_btn
            // 
            this.config_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.config_btn.FlatAppearance.BorderSize = 0;
            this.config_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.config_btn.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.config_btn.IconColor = System.Drawing.Color.White;
            this.config_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.config_btn.IconSize = 32;
            this.config_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.config_btn.Location = new System.Drawing.Point(0, 327);
            this.config_btn.Name = "config_btn";
            this.config_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.config_btn.Size = new System.Drawing.Size(136, 41);
            this.config_btn.TabIndex = 5;
            this.config_btn.Text = "Config";
            this.config_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.config_btn.UseVisualStyleBackColor = true;
            this.config_btn.Click += new System.EventHandler(this.config_btn_Click);
            // 
            // extractor_btn
            // 
            this.extractor_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.extractor_btn.FlatAppearance.BorderSize = 0;
            this.extractor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractor_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.extractor_btn.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.extractor_btn.IconColor = System.Drawing.Color.White;
            this.extractor_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.extractor_btn.IconSize = 32;
            this.extractor_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.extractor_btn.Location = new System.Drawing.Point(0, 368);
            this.extractor_btn.Name = "extractor_btn";
            this.extractor_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.extractor_btn.Size = new System.Drawing.Size(136, 41);
            this.extractor_btn.TabIndex = 4;
            this.extractor_btn.Text = "Extractor";
            this.extractor_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.extractor_btn.UseVisualStyleBackColor = true;
            this.extractor_btn.Click += new System.EventHandler(this.extractor_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.help_btn.FlatAppearance.BorderSize = 0;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.help_btn.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.help_btn.IconColor = System.Drawing.Color.White;
            this.help_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.help_btn.IconSize = 32;
            this.help_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help_btn.Location = new System.Drawing.Point(0, 409);
            this.help_btn.Name = "help_btn";
            this.help_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.help_btn.Size = new System.Drawing.Size(136, 41);
            this.help_btn.TabIndex = 3;
            this.help_btn.Text = "Help";
            this.help_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.title.Controls.Add(this.lblTitleChildForm);
            this.title.Controls.Add(this.iconCurrentChildForm);
            this.title.Controls.Add(this.minimize_btn);
            this.title.Controls.Add(this.close_btn);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(136, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(664, 40);
            this.title.TabIndex = 4;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(58, 9);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(44, 16);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(13)))), ((int)(((byte)(89)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(13)))), ((int)(((byte)(89)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 5);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.minimize_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimize_btn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimize_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.minimize_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize_btn.IconSize = 25;
            this.minimize_btn.Location = new System.Drawing.Point(605, 9);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(25, 25);
            this.minimize_btn.TabIndex = 0;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.close_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.close_btn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.close_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.close_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_btn.IconSize = 25;
            this.close_btn.Location = new System.Drawing.Point(636, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 25);
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click_1);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(8)))), ((int)(((byte)(26)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelShadow.Location = new System.Drawing.Point(136, 40);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(664, 10);
            this.panelShadow.TabIndex = 5;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.panelDesktop.Controls.Add(this.logo);
            this.panelDesktop.Controls.Add(this.status_icon);
            this.panelDesktop.Controls.Add(this.submit_btn);
            this.panelDesktop.Controls.Add(this.redeem_box);
            this.panelDesktop.Controls.Add(this.code_lb);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(136, 50);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(664, 400);
            this.panelDesktop.TabIndex = 6;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(664, 400);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_box_Click);
            // 
            // status_icon
            // 
            this.status_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.status_icon.ForeColor = System.Drawing.Color.Gainsboro;
            this.status_icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.status_icon.IconColor = System.Drawing.Color.Gainsboro;
            this.status_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.status_icon.IconSize = 37;
            this.status_icon.Location = new System.Drawing.Point(131, 205);
            this.status_icon.Name = "status_icon";
            this.status_icon.Size = new System.Drawing.Size(41, 37);
            this.status_icon.TabIndex = 7;
            this.status_icon.TabStop = false;
            this.status_icon.Visible = false;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(449, 205);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(85, 37);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Visible = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // redeem_box
            // 
            this.redeem_box.Location = new System.Drawing.Point(188, 212);
            this.redeem_box.Name = "redeem_box";
            this.redeem_box.Size = new System.Drawing.Size(236, 22);
            this.redeem_box.TabIndex = 5;
            this.redeem_box.Visible = false;
            // 
            // code_lb
            // 
            this.code_lb.AutoSize = true;
            this.code_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.code_lb.ForeColor = System.Drawing.Color.Gainsboro;
            this.code_lb.Location = new System.Drawing.Point(197, 158);
            this.code_lb.Name = "code_lb";
            this.code_lb.Size = new System.Drawing.Size(170, 31);
            this.code_lb.TabIndex = 4;
            this.code_lb.Text = "Redeem Key";
            this.code_lb.Visible = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).EndInit();
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel title;
        private FontAwesome.Sharp.IconButton help_btn;
        private FontAwesome.Sharp.IconButton extractor_btn;
        private FontAwesome.Sharp.IconPictureBox minimize_btn;
        private FontAwesome.Sharp.IconPictureBox close_btn;
        private FontAwesome.Sharp.IconButton config_btn;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox status_icon;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox redeem_box;
        private System.Windows.Forms.Label code_lb;
        private System.Windows.Forms.PictureBox logo_box;
        private System.Windows.Forms.PictureBox logo;
    }
}

