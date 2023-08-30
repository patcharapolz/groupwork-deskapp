using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace WindowsFormsApp1
{
    public partial class FormConfig : Form
    {
        Microsoft.Office.Interop.Excel.Application xlapp;
        Microsoft.Office.Interop.Excel.Workbook xlworkbook;
        Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
        Microsoft.Office.Interop.Excel.Range xlrange;
        public FormConfig()
        {
            InitializeComponent();
            dataname_list.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void data_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string fileaddr = $"C:\\Users\\usar\\Desktop\\project\\groupwork\\Database\\{dataname_list.Text}.xlsx";

            try
            {
                xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(fileaddr);
                xlworksheet = xlworkbook.Worksheets["Sheet1"];
                xlrange = xlworksheet.UsedRange;

                data.ColumnCount = xlrange.Columns.Count;
                int i = 0;
                for (int xlrow = 1; xlrow <= xlrange.Rows.Count; xlrow++)
                {
                    i++;
                    data.Rows.Add(xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text,
                        xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text);
                }
                xlworkbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            path.Text = $"Path:{fileaddr}";
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
