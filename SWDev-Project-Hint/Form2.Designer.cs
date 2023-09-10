
namespace SWDev_Project_Hint
{
	partial class Form2
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
			this.tbSource = new System.Windows.Forms.TextBox();
			this.tbKeyword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bAnalyst_Compare = new System.Windows.Forms.Button();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btContain = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source text";
			// 
			// tbSource
			// 
			this.tbSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.tbSource.Location = new System.Drawing.Point(128, 33);
			this.tbSource.Multiline = true;
			this.tbSource.Name = "tbSource";
			this.tbSource.Size = new System.Drawing.Size(640, 67);
			this.tbSource.TabIndex = 1;
			this.tbSource.Text = "ผมว่าจะมีเหตุการณ์ริบประตูตามแต่มือลาก อีกเยอะ จบฤดูกาลแต้มหายไม่น้อยกว่าสิบแต้ม";
			// 
			// tbKeyword
			// 
			this.tbKeyword.Location = new System.Drawing.Point(128, 130);
			this.tbKeyword.Name = "tbKeyword";
			this.tbKeyword.Size = new System.Drawing.Size(539, 26);
			this.tbKeyword.TabIndex = 2;
			this.tbKeyword.Text = "เหี้ยเอ๋ย";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "keyword";
			// 
			// bAnalyst_Compare
			// 
			this.bAnalyst_Compare.Location = new System.Drawing.Point(128, 261);
			this.bAnalyst_Compare.Name = "bAnalyst_Compare";
			this.bAnalyst_Compare.Size = new System.Drawing.Size(136, 48);
			this.bAnalyst_Compare.TabIndex = 4;
			this.bAnalyst_Compare.Text = "เปรียบเทียบ";
			this.bAnalyst_Compare.UseVisualStyleBackColor = true;
			this.bAnalyst_Compare.Click += new System.EventHandler(this.bAnalyst_Compare_Click);
			// 
			// tbResult
			// 
			this.tbResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbResult.Location = new System.Drawing.Point(128, 162);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.Size = new System.Drawing.Size(539, 72);
			this.tbResult.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "ผลลัพธ์";
			// 
			// btContain
			// 
			this.btContain.Location = new System.Drawing.Point(308, 270);
			this.btContain.Name = "btContain";
			this.btContain.Size = new System.Drawing.Size(133, 39);
			this.btContain.TabIndex = 7;
			this.btContain.Text = "อยู่ภายใน";
			this.btContain.UseVisualStyleBackColor = true;
			this.btContain.Click += new System.EventHandler(this.btContain_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btContain);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.bAnalyst_Compare);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbKeyword);
			this.Controls.Add(this.tbSource);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbSource;
		private System.Windows.Forms.TextBox tbKeyword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bAnalyst_Compare;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btContain;
	}
}