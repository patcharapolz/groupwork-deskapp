using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static subclass.getAddr;

namespace subclass
{
    internal class getAddr
    {
        string[] words = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
        string findWord, getWord;
        public string getAddress(string findWord)
        {

            foreach (var word in words)
            {
                if (findWord.Contains(word))
                {
                    System.Console.WriteLine(word);
                    break;
                }
                //return $"{word}";
            }
            return $"{getWord}";
        }
        public static void Main()
        {
        }
    }
}
