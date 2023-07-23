using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            //วันนี้จะเดินทางเข้ากรุงเทพผ่าน ถนนพระราม1 เขตปทุมวัน เขตปทุม ซอยหลังวัดปทุมวนาราม
            
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
            string[] District_str = { "ปทุมวัน", "พระราม2", "พระราม3" };
            GetDistrict.District = District_str;
            string info_District = GetDistrict.getAddress("District", word);

            getInfo GetAlley = new getInfo();
            string[] Alley_str = { "ซอยหลังวัดปทุมวนาราม", "พระราม2", "พระราม3" };
            GetAlley.Alley = Alley_str;
            string info_Alley = GetAlley.getAddress("Alley", word);

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
            foreach (var address in addresses)
            {
                try
                {
                    var latlong = gls.GetLatLongFromAddress(address);
                    var Latitude = latlong.Latitude;
                    var Longitude = latlong.Longitude;

                    textBox1.Text = String.Format("Address ({0}) is at {1},{2}", address, Latitude, Longitude);
                }
                catch (System.Net.WebException ex)
                {
                    textBox1.Text = String.Format("Google Maps API Error {0}", ex.Message);

                }
            }
        }
    }
}
