namespace WindowsFormsApp1
{
    partial class FormRedeem
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
            this.code_lb = new System.Windows.Forms.Label();
            this.redeem_box = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.status_icon = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.status_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // code_lb
            // 
            this.code_lb.AutoSize = true;
            this.code_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.code_lb.ForeColor = System.Drawing.Color.Gainsboro;
            this.code_lb.Location = new System.Drawing.Point(179, 138);
            this.code_lb.Name = "code_lb";
            this.code_lb.Size = new System.Drawing.Size(170, 31);
            this.code_lb.TabIndex = 0;
            this.code_lb.Text = "Redeem Key";
            // 
            // redeem_box
            // 
            this.redeem_box.Location = new System.Drawing.Point(170, 192);
            this.redeem_box.Name = "redeem_box";
            this.redeem_box.Size = new System.Drawing.Size(236, 22);
            this.redeem_box.TabIndex = 1;
            this.redeem_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.redeem_box_KeyUp);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(431, 185);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(85, 37);
            this.submit_btn.TabIndex = 2;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // status_icon
            // 
            this.status_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.status_icon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status_icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.status_icon.IconColor = System.Drawing.SystemColors.ControlText;
            this.status_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.status_icon.IconSize = 37;
            this.status_icon.Location = new System.Drawing.Point(113, 185);
            this.status_icon.Name = "status_icon";
            this.status_icon.Size = new System.Drawing.Size(41, 37);
            this.status_icon.TabIndex = 3;
            this.status_icon.TabStop = false;
            // 
            // FormRedeem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(664, 400);
            this.Controls.Add(this.status_icon);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.redeem_box);
            this.Controls.Add(this.code_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRedeem";
            this.Text = "FormRedeem";
            ((System.ComponentModel.ISupportInitialize)(this.status_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label code_lb;
        private System.Windows.Forms.TextBox redeem_box;
        private System.Windows.Forms.Button submit_btn;
        private FontAwesome.Sharp.IconPictureBox status_icon;
    }
}