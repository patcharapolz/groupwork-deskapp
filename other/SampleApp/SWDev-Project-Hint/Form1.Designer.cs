
namespace SWDev_Project_Hint
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbInputFile = new System.Windows.Forms.TextBox();
			this.btBrowse = new System.Windows.Forms.Button();
			this.btOK = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.tbContent = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPosition = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbTrainset = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbTrainsetFile = new System.Windows.Forms.TextBox();
			this.btTrainsetFile = new System.Windows.Forms.Button();
			this.btLoadTrainset = new System.Windows.Forms.Button();
			this.btAnalyst = new System.Windows.Forms.Button();
			this.tbCurrentLine = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input File";
			// 
			// tbInputFile
			// 
			this.tbInputFile.Location = new System.Drawing.Point(167, 25);
			this.tbInputFile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.tbInputFile.Name = "tbInputFile";
			this.tbInputFile.Size = new System.Drawing.Size(573, 38);
			this.tbInputFile.TabIndex = 1;
			// 
			// btBrowse
			// 
			this.btBrowse.Location = new System.Drawing.Point(770, 7);
			this.btBrowse.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btBrowse.Name = "btBrowse";
			this.btBrowse.Size = new System.Drawing.Size(126, 73);
			this.btBrowse.TabIndex = 2;
			this.btBrowse.Text = "Browse";
			this.btBrowse.UseVisualStyleBackColor = true;
			this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(916, 7);
			this.btOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(115, 73);
			this.btOK.TabIndex = 3;
			this.btOK.Text = "Load";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(1102, 1052);
			this.btExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(282, 73);
			this.btExit.TabIndex = 4;
			this.btExit.Text = "Exit";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// tbContent
			// 
			this.tbContent.Location = new System.Drawing.Point(20, 123);
			this.tbContent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.tbContent.Multiline = true;
			this.tbContent.Name = "tbContent";
			this.tbContent.Size = new System.Drawing.Size(720, 713);
			this.tbContent.TabIndex = 5;
			this.tbContent.WordWrap = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(255, 32);
			this.label2.TabIndex = 6;
			this.label2.Text = "ข้อมูลที่อยากทราบพิกัด";
			// 
			// tbPosition
			// 
			this.tbPosition.Location = new System.Drawing.Point(750, 123);
			this.tbPosition.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.tbPosition.Multiline = true;
			this.tbPosition.Name = "tbPosition";
			this.tbPosition.Size = new System.Drawing.Size(425, 713);
			this.tbPosition.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(744, 86);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 32);
			this.label3.TabIndex = 8;
			this.label3.Text = "พิกัด";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1336, 25);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 32);
			this.label4.TabIndex = 9;
			this.label4.Text = "Trainset";
			// 
			// tbTrainset
			// 
			this.tbTrainset.Location = new System.Drawing.Point(1332, 151);
			this.tbTrainset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.tbTrainset.Multiline = true;
			this.tbTrainset.Name = "tbTrainset";
			this.tbTrainset.Size = new System.Drawing.Size(1010, 842);
			this.tbTrainset.TabIndex = 10;
			this.tbTrainset.Text = "\"กรุงเทพ\",\"13.45N\",\"100.28E\"\r\n\"สถาบันเทคโนโลยีจิตรลดา\",\"13.03N\",\"100.18E\"\r\n\"พรรคเ" +
    "พื่อไทย\",\"13.44N\",\"100.8E\"\r\n";
			this.tbTrainset.WordWrap = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(1336, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 32);
			this.label5.TabIndex = 11;
			this.label5.Text = "File";
			// 
			// tbTrainsetFile
			// 
			this.tbTrainsetFile.Location = new System.Drawing.Point(1404, 86);
			this.tbTrainsetFile.Name = "tbTrainsetFile";
			this.tbTrainsetFile.Size = new System.Drawing.Size(598, 38);
			this.tbTrainsetFile.TabIndex = 12;
			// 
			// btTrainsetFile
			// 
			this.btTrainsetFile.Location = new System.Drawing.Point(2008, 62);
			this.btTrainsetFile.Name = "btTrainsetFile";
			this.btTrainsetFile.Size = new System.Drawing.Size(138, 81);
			this.btTrainsetFile.TabIndex = 13;
			this.btTrainsetFile.Text = "browse";
			this.btTrainsetFile.UseVisualStyleBackColor = true;
			// 
			// btLoadTrainset
			// 
			this.btLoadTrainset.Location = new System.Drawing.Point(2152, 62);
			this.btLoadTrainset.Name = "btLoadTrainset";
			this.btLoadTrainset.Size = new System.Drawing.Size(192, 81);
			this.btLoadTrainset.TabIndex = 14;
			this.btLoadTrainset.Text = "Load Trainset";
			this.btLoadTrainset.UseVisualStyleBackColor = true;
			// 
			// btAnalyst
			// 
			this.btAnalyst.Location = new System.Drawing.Point(1039, 7);
			this.btAnalyst.Name = "btAnalyst";
			this.btAnalyst.Size = new System.Drawing.Size(173, 73);
			this.btAnalyst.TabIndex = 15;
			this.btAnalyst.Text = "Analyst";
			this.btAnalyst.UseVisualStyleBackColor = true;
			this.btAnalyst.Click += new System.EventHandler(this.btAnalyst_Click);
			// 
			// tbCurrentLine
			// 
			this.tbCurrentLine.Location = new System.Drawing.Point(20, 895);
			this.tbCurrentLine.Multiline = true;
			this.tbCurrentLine.Name = "tbCurrentLine";
			this.tbCurrentLine.Size = new System.Drawing.Size(1155, 105);
			this.tbCurrentLine.TabIndex = 16;
			this.tbCurrentLine.WordWrap = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 857);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(164, 32);
			this.label6.TabIndex = 17;
			this.label6.Text = "CurrentLine";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2416, 1178);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbCurrentLine);
			this.Controls.Add(this.btAnalyst);
			this.Controls.Add(this.btLoadTrainset);
			this.Controls.Add(this.btTrainsetFile);
			this.Controls.Add(this.tbTrainsetFile);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbTrainset);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbPosition);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbContent);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.btBrowse);
			this.Controls.Add(this.tbInputFile);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "Form1";
			this.Text = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbInputFile;
		private System.Windows.Forms.Button btBrowse;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.TextBox tbContent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPosition;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbTrainset;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbTrainsetFile;
		private System.Windows.Forms.Button btTrainsetFile;
		private System.Windows.Forms.Button btLoadTrainset;
		private System.Windows.Forms.Button btAnalyst;
		private System.Windows.Forms.TextBox tbCurrentLine;
		private System.Windows.Forms.Label label6;
	}
}

