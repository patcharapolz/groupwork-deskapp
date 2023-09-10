
namespace SWDev_Project_Hint
{
	partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.TextData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 559);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "file";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(118, 51);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(477, 22);
            this.tbFileName.TabIndex = 2;
            this.tbFileName.Text = "E:\\Download\\pantip5.txt";
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(614, 47);
            this.btBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(92, 35);
            this.btBrowse.TabIndex = 3;
            this.btBrowse.Text = "browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(731, 47);
            this.btLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(73, 36);
            this.btLoad.TabIndex = 4;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(63, 127);
            this.tbData.Margin = new System.Windows.Forms.Padding(2);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbData.Size = new System.Drawing.Size(194, 403);
            this.tbData.TabIndex = 5;
            this.tbData.WordWrap = false;
            this.tbData.TextChanged += new System.EventHandler(this.tbData_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data";
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(274, 127);
            this.rtbData.Margin = new System.Windows.Forms.Padding(2);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(177, 403);
            this.rtbData.TabIndex = 7;
            this.rtbData.Text = "";
            this.rtbData.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "RTB Data";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextData,
            this.Lat,
            this.Long});
            this.dgvData.Location = new System.Drawing.Point(477, 127);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 102;
            this.dgvData.RowTemplate.Height = 40;
            this.dgvData.Size = new System.Drawing.Size(595, 401);
            this.dgvData.TabIndex = 9;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // TextData
            // 
            this.TextData.HeaderText = "Text";
            this.TextData.MinimumWidth = 12;
            this.TextData.Name = "TextData";
            this.TextData.Width = 400;
            // 
            // Lat
            // 
            this.Lat.HeaderText = "ละดิจูด";
            this.Lat.MinimumWidth = 12;
            this.Lat.Name = "Lat";
            this.Lat.Width = 250;
            // 
            // Long
            // 
            this.Long.HeaderText = "ลองดิจูด";
            this.Long.MinimumWidth = 12;
            this.Long.Name = "Long";
            this.Long.Width = 250;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "DGV Data";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.Button btBrowse;
		private System.Windows.Forms.Button btLoad;
		private System.Windows.Forms.TextBox tbData;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox rtbData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.DataGridViewTextBoxColumn TextData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Long;
		private System.Windows.Forms.Label label4;
	}
}