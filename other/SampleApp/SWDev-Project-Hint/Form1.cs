using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWDev_Project_Hint
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        private void ReadTextFile(string strPath)
        {
            StreamReader stReader = new StreamReader(strPath, Encoding.GetEncoding("UTF-8"));
            tbContent.Text = stReader.ReadToEnd();
            stReader.Close();
        }
		private void btExit_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
            ReadTextFile(tbInputFile.Text);
		}

		private void btBrowse_Click(object sender, EventArgs e)
		{

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"Documents",
                Title = "Browse for the text file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "data file(*.txt)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
				tbInputFile.Text =  openFileDialog1.FileName;
            }
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		private void Read1Line(string strData)
		{
			// not finish
			int i;
			char cCurrent;
			for ( i=0; i<strData.Length; i++ )
			{
				cCurrent = strData[i];
				if ( cCurrent == 10 )
					break;

			}
		}
		private void btAnalyst_Click(object sender, EventArgs e)
		{
			Read1Line(tbContent.Text);
		}
	}
}
