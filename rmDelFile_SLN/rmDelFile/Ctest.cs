using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmDelFile
{
    class Ctest
    {
        public void test(object sender, EventArgs e)
        {
            List<string> Name = new List<string>();
            Name.Add("a");
            Name.Add("b");
            Name.Add("c");
            List<int> Except = new List<int>();
            Except.Add(1);
            Except.Add(2);
            Except.Add(3);
            List<string> FinalLine = new List<string>();
            
            //string[] NameTab = NameList.ToArray();
            //string[] ExceptTab = ExceptList.ToArray();
            //string[] FinalLine = new string[] { };
            foreach (string NameF in Name)
            {
                foreach (int Excep in Except)
                {
                    string line = DateTime.Now + " : Erreur sur le fichier : " + NameF + " : " + Excep;

                    FinalLine.Add(line);
                }

            }
            Console.WriteLine("FinalLine:");
            foreach (string i in FinalLine)
            {
                Console.WriteLine(i);
            }
        }
    }
}
