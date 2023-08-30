using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleMaps.LocationServices;
using subclass;
using static System.Windows.Forms.AxHost;

namespace test
{

    
    public partial class Form1 : Form
    {
        double lat { get; set; }
        double lon { get; set; }
        public Form1()
        {
            InitializeComponent();
            //วันนี้จะเดินทางเข้ากรุงเทพผ่าน ถนนพระราม1 เขตปทุมวัน ซอยหลังวัดปทุมวนาราม
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox2.Text;

            getInfo GetProvince = new getInfo();
            string[] Province_str = { "กรุงเทพ", "จันทรบุรี", "บุรีรัม" };
            GetProvince.Province = Province_str;
            string info_Province = GetProvince.getAddress("Province", word);

            getInfo GetRoad = new getInfo();
            string[] Road_str = { "พระราม1", "พระราม2", "พระราม3" };
            GetRoad.Road = Road_str;
            string info_Road = GetRoad.getAddress("Road", word);

            getInfo GetDistrict = new getInfo();
            string[] District_str = { "ปทุมวัน" };
            GetDistrict.District = District_str;
            string info_District = GetDistrict.getAddress("District", word);

            getInfo GetAlley = new getInfo();
            string[] Alley_str = { "หลังวัดปทุมวนาราม" };
            GetAlley.Alley = Alley_str;
            string info_Alley = GetAlley.getAddress("Alley", word);

            string text = $"{info_Province} {info_Road} {info_District} {info_District} {info_Alley}";

            AddressData[] addresses = new AddressData[]
            {
                new AddressData // Belgium
                {
                    Address = $"{info_Province} {info_Road} {info_District} {info_District} {info_Alley}",
                    City = null,
                    State = null,
                    Country = "ไทย",
                    Zip = null
                }

            };

            
            // Constructor has 3 overload
            // No parameters. It does not use API Key
            var gls = new GoogleLocationService("AIzaSyCUb6WUldSy25V87ZWz7cL1CeC3K-ZLtjg");

            label3.Text = text;
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox1.Text = "Location Missing";
            }
            else
            {
                foreach (var address in addresses)
                {
                    try
                    {
                        var latlong = gls.GetLatLongFromAddress(address);
                        var Latitude = latlong.Latitude;
                        var Longitude = latlong.Longitude;

                        lat = Latitude;
                        lon = Longitude;
                        textBox1.Text = String.Format("Address ({0}) is at {1},{2}", address, Latitude, Longitude);
                    }
                    catch (System.Net.WebException ex)
                    {
                        textBox1.Text = String.Format("Google Maps API Error {0}", ex.Message);

                    }
                }
            }
        }

        private void map_btn_Click_1(object sender, EventArgs e)
        {
            string db = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(db);

            try
            {
                conn.Open();
                label2.Text = "Connect";
            }
            catch (Exception ex)
            {
                label2.Text = "Error" + ex.Message;
                conn.Close();
            }
        }
    }
}
