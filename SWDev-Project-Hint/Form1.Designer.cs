
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input File";
			// 
			// tbInputFile
			// 
			this.tbInputFile.Location = new System.Drawing.Point(96, 91);
			this.tbInputFile.Name = "tbInputFile";
			this.tbInputFile.Size = new System.Drawing.Size(324, 26);
			this.tbInputFile.TabIndex = 1;
			// 
			// btBrowse
			// 
			this.btBrowse.Location = new System.Drawing.Point(435, 80);
			this.btBrowse.Name = "btBrowse";
			this.btBrowse.Size = new System.Drawing.Size(71, 47);
			this.btBrowse.TabIndex = 2;
			this.btBrowse.Text = "Browse";
			this.btBrowse.UseVisualStyleBackColor = true;
			this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(517, 80);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(65, 47);
			this.btOK.TabIndex = 3;
			this.btOK.Text = "Load";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(168, 665);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(159, 47);
			this.btExit.TabIndex = 4;
			this.btExit.Text = "Exit";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// tbContent
			// 
			this.tbContent.Location = new System.Drawing.Point(13, 154);
			this.tbContent.Multiline = true;
			this.tbContent.Name = "tbContent";
			this.tbContent.Size = new System.Drawing.Size(407, 387);
			this.tbContent.TabIndex = 5;
			this.tbContent.WordWrap = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "ข้อมูลที่อยากทราบพิกัด";
			// 
			// tbPosition
			// 
			this.tbPosition.Location = new System.Drawing.Point(424, 154);
			this.tbPosition.Multiline = true;
			this.tbPosition.Name = "tbPosition";
			this.tbPosition.Size = new System.Drawing.Size(241, 387);
			this.tbPosition.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(420, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "พิกัด";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(754, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Trainset";
			// 
			// tbTrainset
			// 
			this.tbTrainset.Location = new System.Drawing.Point(751, 172);
			this.tbTrainset.Multiline = true;
			this.tbTrainset.Name = "tbTrainset";
			this.tbTrainset.Size = new System.Drawing.Size(570, 459);
			this.tbTrainset.TabIndex = 10;
			this.tbTrainset.Text = "\"กรุงเทพ\",\"13.45N\",\"100.28E\"\r\n\"สถาบันเทคโนโลยีจิตรลดา\",\"13.03N\",\"100.18E\"\r\n\"พรรคเ" +
    "พื่อไทย\",\"13.44N\",\"100.8E\"\r\n";
			this.tbTrainset.WordWrap = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(754, 130);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "File";
			// 
			// tbTrainsetFile
			// 
			this.tbTrainsetFile.Location = new System.Drawing.Point(792, 130);
			this.tbTrainsetFile.Margin = new System.Windows.Forms.Padding(2);
			this.tbTrainsetFile.Name = "tbTrainsetFile";
			this.tbTrainsetFile.Size = new System.Drawing.Size(338, 26);
			this.tbTrainsetFile.TabIndex = 12;
			// 
			// btTrainsetFile
			// 
			this.btTrainsetFile.Location = new System.Drawing.Point(1132, 115);
			this.btTrainsetFile.Margin = new System.Windows.Forms.Padding(2);
			this.btTrainsetFile.Name = "btTrainsetFile";
			this.btTrainsetFile.Size = new System.Drawing.Size(78, 52);
			this.btTrainsetFile.TabIndex = 13;
			this.btTrainsetFile.Text = "browse";
			this.btTrainsetFile.UseVisualStyleBackColor = true;
			// 
			// btLoadTrainset
			// 
			this.btLoadTrainset.Location = new System.Drawing.Point(1212, 115);
			this.btLoadTrainset.Margin = new System.Windows.Forms.Padding(2);
			this.btLoadTrainset.Name = "btLoadTrainset";
			this.btLoadTrainset.Size = new System.Drawing.Size(108, 52);
			this.btLoadTrainset.TabIndex = 14;
			this.btLoadTrainset.Text = "Load Trainset";
			this.btLoadTrainset.UseVisualStyleBackColor = true;
			// 
			// btAnalyst
			// 
			this.btAnalyst.Location = new System.Drawing.Point(586, 80);
			this.btAnalyst.Margin = new System.Windows.Forms.Padding(2);
			this.btAnalyst.Name = "btAnalyst";
			this.btAnalyst.Size = new System.Drawing.Size(97, 47);
			this.btAnalyst.TabIndex = 15;
			this.btAnalyst.Text = "Analyst";
			this.btAnalyst.UseVisualStyleBackColor = true;
			this.btAnalyst.Click += new System.EventHandler(this.btAnalyst_Click);
			// 
			// tbCurrentLine
			// 
			this.tbCurrentLine.Location = new System.Drawing.Point(11, 577);
			this.tbCurrentLine.Margin = new System.Windows.Forms.Padding(2);
			this.tbCurrentLine.Multiline = true;
			this.tbCurrentLine.Name = "tbCurrentLine";
			this.tbCurrentLine.Size = new System.Drawing.Size(651, 69);
			this.tbCurrentLine.TabIndex = 16;
			this.tbCurrentLine.WordWrap = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 555);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 20);
			this.label6.TabIndex = 17;
			this.label6.Text = "CurrentLine";
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1333, 33);
			this.menuStrip1.TabIndex = 20;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mainToolStripMenuItem
			// 
			this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem});
			this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
			this.mainToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
			this.mainToolStripMenuItem.Text = "Main";
			// 
			// form2ToolStripMenuItem
			// 
			this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
			this.form2ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.form2ToolStripMenuItem.Text = "form2";
			this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
			// 
			// form3ToolStripMenuItem
			// 
			this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
			this.form3ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.form3ToolStripMenuItem.Text = "form3";
			this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1333, 772);
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
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Main";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
	}
}

