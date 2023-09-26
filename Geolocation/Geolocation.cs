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
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Runtime.InteropServices;



namespace WindowsFormsApp1.Forms
{

    public partial class Geolocation : Form
    {
        Microsoft.Office.Interop.Excel.Application xlapp;
        Microsoft.Office.Interop.Excel.Workbook xlworkbook;
        Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
        Microsoft.Office.Interop.Excel.Range xlrange;
        
        public string getpath = (System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).Replace("\\bin\\Debug", "");
        List<string> key_contain = new List<string>();
        string contain = "";
        public int iLineNo = 1;
        public List<string> all = new List<string>();

        public Geolocation()
        {
            InitializeComponent();

        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            tbData.Text = "";
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

            foreach (string strLine in System.IO.File.ReadLines(pathfile_box.Text))
            {
                tbData.Text += iLineNo.ToString() + " [" + strLine + "]" + Environment.NewLine;
                all.Add(strLine);
                iLineNo++;
            }
        }

        private string get_info(string filepath, int count)
        {
            try
            {
                xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(filepath);
                xlworksheet = xlworkbook.Worksheets["Sheet1"];
                xlrange = xlworksheet.UsedRange;
                int range = xlrange.Rows.Count;

                for (int idxRow = 1; idxRow <= xlrange.Rows.Count; idxRow++)
                {
                    string key = xlworksheet.Cells[idxRow, 1].Value.ToString();
                    if (all[count].Contains(key))
                    {
                        xlworkbook.Close(true);
                        xlapp.Quit();
                        return key;
                    }
                }
                
                
                xlworkbook.Close(0);
                xlapp.Quit();
                return "";
            } catch (COMException ce)
            {
                xlworkbook.Close(0);
                xlapp.Quit();
                return "";
            }
            
        }

        private void Analysis_Click(object sender, EventArgs e)
        {
            string path = "";
            string province = "", road = "", district = "", subdistrict = "";
            string province_path = $"{getpath}\\data\\จังหวัด.xlsx";
            string road_path = $"{getpath}\\data\\ถนน.xlsx";
            List<string> item = new List<string>();
            for (int idx = 0; idx < (iLineNo - 1); idx++)
            {
                path = get_info(province_path, idx);
                province = get_info(province_path, idx);
                road = get_info(road_path, idx);

                string district_path = $"{getpath}\\data\\{path}\\{path}_เขต.xlsx";
                string subdistrict_path = $"{getpath}\\data\\{path}\\{path}_แขวง.xlsx";

                district = get_info(district_path, idx);
                subdistrict = get_info(subdistrict_path, idx);

                contain = $"{province}, {road}, {district}, {subdistrict}";
                item.Add(contain);
                item.Add(idx.ToString());
                dgvData.Rows[dgvData.Rows.Add(all[idx])].Cells[1].Value = contain;
                dgvData.Rows[idx].Cells[2].Value = getLat(contain);
                dgvData.Rows[idx].Cells[3].Value = getLon(contain);
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
            dgvData.Refresh();
            tbData.Clear();
            pathfile_box.Clear();
            all.Clear();
            iLineNo = 1;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Geolocation_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(800, 450);
            dgvData.Size = new System.Drawing.Size(552, 350);
            tbData.Size = new System.Drawing.Size(188, 350);
            label1.Size = new System.Drawing.Size(32, 16);
            pathfile_box.Size = new System.Drawing.Size(417, 22);
            import_btn.Size = new System.Drawing.Size(105, 32);
            Analysis.Size = new System.Drawing.Size(105, 32);
            reset_btn.Size = new System.Drawing.Size(105, 32);

            dgvData.Location = new System.Drawing.Point(236, 88);
            tbData.Location = new System.Drawing.Point(15, 88);
            label1.Location = new System.Drawing.Point(12, 50);
            pathfile_box.Location = new System.Drawing.Point(50, 50);
            import_btn.Location = new System.Drawing.Point(473, 45);
            Analysis.Location = new System.Drawing.Point(584, 45);
            reset_btn.Location = new System.Drawing.Point(695, 45);
        }

        public string getLat(string addr)
        {
            latlon address = new latlon();
            address.Addr = addr;
            try
            {
                object latitude = PythonInterop.RunPythonCodeAndReturn(
    @"from geopy.geocoders import Nominatim
locator = Nominatim(user_agent=""Geoloation"");
location = locator.geocode(address.Addr);
address.Lat = location.latitude;
latitude = address.Lat", address, "address", "latitude");

                string lat = latitude.ToString();
                return lat;
            }
            catch
            {
                return "";
            }
        }
        public string getLon(string addr)
        {
            latlon address = new latlon();
            address.Addr = addr;
            try
            {
                object longitude = PythonInterop.RunPythonCodeAndReturn(
    @"from geopy.geocoders import Nominatim
locator = Nominatim(user_agent=""Geoloation"");
location = locator.geocode(address.Addr);
address.Lon = location.longitude;
longitude = address.Lon", address, "address", "longitude");
                
                string lon = longitude.ToString();
                return lon;
            }
            catch
            {
                return "";
            }
        }
        public class latlon
        {
            public string Addr { get; set; }
            public float Lat { get; set; }
            public float Lon { get; set; }
        }
    }
    
}
