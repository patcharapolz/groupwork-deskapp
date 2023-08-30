using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Import_Excel
{
    public partial class Form1 : Form
    {

        bool isAdmin = false;
        
        public Form1()
        {
            InitializeComponent();

        }


        private void filename_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlapp;
            Microsoft.Office.Interop.Excel.Workbook xlworkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
            Microsoft.Office.Interop.Excel.Range xlrange;

            string fileaddr = $"C:\\Users\\usar\\Desktop\\project\\groupwork\\Database\\{filename_box.Text}.xlsx";
            
            try
            {
                xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(fileaddr);
                xlworksheet = xlworkbook.Worksheets["Sheet1"];
                xlrange = xlworksheet.UsedRange;

                Data.ColumnCount = xlrange.Columns.Count;
                int i = 0;
                for (int xlrow = 1; xlrow <= xlrange.Rows.Count; xlrow++)
                {
                    i++;
                    Data.Rows.Add(xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text,
                        xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text);
                }
                xlworkbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = isAdmin.ToString();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if(key_textbox.Text == "guadmin")
            {
                isAdmin = true;
            } else isAdmin = false;

            if (isAdmin)
            {
                btn.Visible = true;
                status_icon.IconChar = FontAwesome.Sharp.IconChar.Check;
                status_icon.IconColor = Color.Green;
            }
            else
            {
                btn.Visible = false;
                status_icon.IconChar = FontAwesome.Sharp.IconChar.Xmark;
                status_icon.IconColor = Color.Red;
            }

            label1.Text = isAdmin.ToString();
        }

    }
}
