using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWDev_Project_Hint
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
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
				tbFileName.Text =  openFileDialog1.FileName;
            }
		}

		private void btLoad_Click(object sender, EventArgs e)
		{
            int iLineNo=1;
            tbData.Text = "";
            rtbData.ResetText();
            string[] strArrColumn = new string[3];
            foreach ( string strLine in System.IO.File.ReadLines(tbFileName.Text))
            {
                tbData.Text     += iLineNo.ToString() + " [" + strLine + "]" + Environment.NewLine;
                rtbData.AppendText(iLineNo.ToString() + " [" + strLine + "]" + Environment.NewLine); 

                strArrColumn[0] = strLine;
                // calculation 

                strArrColumn[1] = "lat?";
                strArrColumn[2] = "long?";
                dgvData.Rows.Add(strArrColumn);

                iLineNo++;
            }
		}

        private void tbData_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
