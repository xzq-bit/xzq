using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleExample4
{
    class Sub:JiSuan
    {
        string str;
        string str1;

        public string Str { get => str; set => str = value; }
        public string Str1 { get => str1; set => str1 = value; }

        public override void GetNum()
        {
             string StringRepace()
            {
                
                Regex r = new Regex(str1);
                str = r.Replace(str, "");
                return str;
            }

            Console.WriteLine(StringRepace());
            Console.WriteLine(Num = A - B);
            
        }
    }
}
