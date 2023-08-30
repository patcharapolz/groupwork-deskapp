namespace WindowsFormsApp1
{
    partial class FormConfig
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
            this.dataname_list = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.edit_btn = new FontAwesome.Sharp.IconButton();
            this.save_btn = new FontAwesome.Sharp.IconButton();
            this.del_btn = new FontAwesome.Sharp.IconButton();
            this.path = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // dataname_list
            // 
            this.dataname_list.Items.AddRange(new object[] {
            "จังหวัด",
            "เขต",
            "แขวง",
            "ถนน"});
            this.dataname_list.Location = new System.Drawing.Point(120, 51);
            this.dataname_list.Name = "dataname_list";
            this.dataname_list.Size = new System.Drawing.Size(184, 24);
            this.dataname_list.TabIndex = 0;
            this.dataname_list.SelectedIndexChanged += new System.EventHandler(this.data_name_SelectedIndexChanged);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(310, 39);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(238, 302);
            this.data.TabIndex = 1;
            // 
            // edit_btn
            // 
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.edit_btn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.edit_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.edit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit_btn.IconSize = 32;
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(192, 228);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(100, 45);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Edit";
            this.edit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.save_btn.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.save_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.save_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.save_btn.IconSize = 32;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(191, 177);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(100, 45);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // del_btn
            // 
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.del_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.del_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.del_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.del_btn.IconSize = 32;
            this.del_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del_btn.Location = new System.Drawing.Point(191, 279);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(100, 45);
            this.del_btn.TabIndex = 2;
            this.del_btn.Text = "Delete";
            this.del_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.del_btn.UseVisualStyleBackColor = true;
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.path.ForeColor = System.Drawing.Color.Gainsboro;
            this.path.Location = new System.Drawing.Point(25, 365);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(58, 25);
            this.path.TabIndex = 3;
            this.path.Text = "Path:";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(108, 101);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(137, 22);
            this.edit.TabIndex = 4;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(7)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(664, 400);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.path);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.data);
            this.Controls.Add(this.dataname_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "Config";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dataname_list;
        private System.Windows.Forms.DataGridView data;
        private FontAwesome.Sharp.IconButton edit_btn;
        private FontAwesome.Sharp.IconButton save_btn;
        private FontAwesome.Sharp.IconButton del_btn;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.TextBox edit;
    }
}