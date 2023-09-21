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
            //MessageBox.Show(all.Count.ToString());
        }

        private void Analysis_Click(object sender, EventArgs e)
        {
            //string filepath = $"{getpath}\\data\\test.xlsx";
            string filepath = $"{getpath}\\Database\\รวม.xlsx";
            List<string> key_contain = new List<string>();
            string contain = "", text_contain = "";
            int idx = 0;
            int countIdx = 0;
            xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlworkbook = xlapp.Workbooks.Open(filepath);
            xlworksheet = xlworkbook.Worksheets["Sheet1"];
            xlrange = xlworksheet.UsedRange;
            int range = xlrange.Rows.Count;
            MessageBox.Show(xlrange.Count.ToString());
            for (idx = 0; idx < (iLineNo - 1); idx++) 
            {
               
                if (countIdx == (all.Count))
                {
                    MessageBox.Show("Stop");
                    break;
                }
                for (int idxRow = 1; idxRow<=xlrange.Rows.Count; idxRow++)
                {
                    contain = "";
                    text_contain = "";
                    key_contain.Clear();
   

                    for (int idxCol = 1; idxCol<= xlrange.Columns.Count; idxCol++)
                    {

                        string key = xlworksheet.Cells[idxRow, idxCol].Value.ToString();
                        //MessageBox.Show($"Text = {all[idx]} Key = {key}");
                        textBox1.Text = all[idx];
                        textBox2.Text = key;
                        if (key == "NULL")
                        {
                            break;
                        }
                        if (all[idx].Contains(key))
                        {
                            text_contain = all[idx];
                            key_contain.Add(key);
                            all[idx] = all[idx].Replace(key, "");
                        }
                    }
                    if (text_contain != "")
                    {
                        countIdx++;
                        contain = String.Join(",", key_contain);
                        dgvData.Rows[dgvData.Rows.Add(text_contain)].Cells[1].Value = contain;
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
