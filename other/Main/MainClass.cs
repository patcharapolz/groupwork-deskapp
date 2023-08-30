using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using subclass;

namespace Main
{
    internal class MainClass
    {
        static void Main()
        {
            string word = "วันนี้จะเดินทางเข้ากรุงเทพผ่าน ถนนพระราม1 เขตปทุมวัน เขตปทุม ซอยหลังวัดปทุมวนาราม";
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


            System.Console.WriteLine($"{info_Province} {info_Road} {info_District} {info_District} ");
        }
    }
}
