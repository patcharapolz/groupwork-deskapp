using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace ConsoleApp1
{
    internal class MyProgram
    {

        static void RunScript()
        {

            string pythonDll = @"C:\Users\usar\AppData\Local\Programs\Python\Python311\python311.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
            //using (Py.GIL())
            //{
            //    //var pyCode = Py.Import(scriptName);
            //    //var result = pyCode.InvokeMethod("msg");
            //    dynamic getLatLon = Py.Import(scriptName);
            //    Console.WriteLine(getLatLon.getMsg);
            //}

            using (Py.GIL())
            {
                //var scope = Py.CreateScope();
                //scope.Exec("print('Hello World from Python!')");
                //scope.Import("getMsg");
                //dynamic hello = PythonEngine.RunSimpleString("print('Hello World from Python!')");

                dynamic test = Py.Import("geopy.geocoders");
                dynamic hello = PythonEngine.RunSimpleString("print('Hello World from Python!');");
                //dynamic r1 = PythonEngine.RunSimpleString("test.msg()");
                //PythonEngine.Shutdown();
            }
        }
    //    def getLat(addr): location = locator.geocode(addr);
    //    return f""Latitude = {location.latitude
    //}"";
        static void Main(string[] args)
        {
            //            PythonInterop.RunPythonCode(
            //@"from geopy.geocoders import Nominatim
            //locator = Nominatim(user_agent=""Geoloation"");

            //location = locator.geocode('กรุงเทพ, พระราม 1, ปทุมวัน, ปทุมวัน');
            //print(location.latitude);
            //");
            Person someone = new Person();
            someone.Addr = "กรุงเทพ, พระราม 1, ปทุมวัน, ปทุมวัน";


            object latitude = PythonInterop.RunPythonCodeAndReturn(
@"from geopy.geocoders import Nominatim
locator = Nominatim(user_agent=""Geoloation"");
location = locator.geocode(someone.Addr);
someone.Lat = location.latitude;
lati = someone.Lat", someone, "someone", "lati");

            Console.WriteLine("his age became " + latitude.ToString());

            object longitude = PythonInterop.RunPythonCodeAndReturn(
@"from geopy.geocoders import Nominatim
locator = Nominatim(user_agent=""Geoloation"");
location = locator.geocode(someone.Addr);
someone.Lon = location.longitude;
longi = someone.Lon", someone, "someone", "longi");

            Console.WriteLine("his age became " + longitude.ToString());

        }

        public class Person
        {
            public string Addr { get; set; }
            public float Lat { get; set; }
            public float Lon { get; set; }
        }
    }
}
