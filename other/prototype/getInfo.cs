using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace subclass
{
    internal class getInfo
    {   
        public string[] words;
        public string[] Province { get; set; }
        public string[] Road { get; set; }
        public string[] Sub_District { get; set; }
        public string[] District { get; set; }
        public string[] Alley { get; set; }
        string getWord;
        public string getAddress(string findtype, string findWord)
        {
            switch (findtype)
            {
                case "Province":
                    words = Province; break;
                case "Road":
                    words = Road; break;
                case "Sub_District":
                    words = Sub_District; break;
                case "District":
                    words = District; break;
                case "Alley":
                    words = Alley; break;
            }
            foreach (var word in words)
            {
                if (findWord.Contains(word))
                {
                    getWord = word;
                    break;
                }
                else
                {
                    getWord = "";
                    break;
                }
                //return $"{word}";
            }
            return $"{getWord}";
        }
    }


}
