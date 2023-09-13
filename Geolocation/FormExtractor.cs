using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Windows.Controls;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp1.Forms
{
    public partial class FormExtractor : Form
    {
        Microsoft.Office.Interop.Excel.Application xlapp;
        Microsoft.Office.Interop.Excel.Workbook xlworkbook;
        Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
        Microsoft.Office.Interop.Excel.Range xlrange;
        public List<string> all = new List<string>();
        public string getpath = (System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).Replace("\\bin\\Debug",""); 
        public FormExtractor()
        {
            InitializeComponent();
            
        }

        private void browse_btn_Click(object sender, EventArgs e)
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
                pathfile_box.Text = openFileDialog1.FileName;
            }
        }

        public int iLineNo = 1;
        private void load_btn_Click(object sender, EventArgs e)
        {
            tbData.Text = "";
            string[] strArrColumn = new string[3];
            foreach (string strLine in System.IO.File.ReadLines(pathfile_box.Text))
            {
                tbData.Text += iLineNo.ToString() + " [" + strLine + "]" + Environment.NewLine;
                all.Add(strLine);
                // calculation 

                //strArrColumn[1] = "lat?";
                //strArrColumn[2] = "long?";


                
                iLineNo++;
            }
            
        }

        private void Analysis_Click(object sender, EventArgs e)
        {
            string filepath = $"{getpath}\\Database\\จังหวัด.xlsx";
            string[] strArrColumn = new string[3];
            int idx = 0;
            xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlworkbook = xlapp.Workbooks.Open(filepath);
            xlworksheet = xlworkbook.Worksheets["Sheet1"];
            xlrange = xlworksheet.UsedRange;
            int range = xlrange.Rows.Count;
            for (int i = 1; i<=xlrange.Rows.Count; i++) 
            {
                idx = 0;
                string key = xlworksheet.Cells[i, 1].Value.ToString();
                for (idx=0;idx<(iLineNo-1);idx++)
                { 
                    if (all[idx].Contains(key))
                    {
                        dgvData.Rows[dgvData.Rows.Add(all[idx])].Cells[1].Value = key;
                        all[idx] = all[idx].Replace(key, "");
                    }
                }


            }
            xlworkbook.Close();
            xlapp.Quit();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
           dgvData.Refresh();
            tbData.Clear();
            pathfile_box.Clear();
            all.Clear();

        }
    }
    
}
