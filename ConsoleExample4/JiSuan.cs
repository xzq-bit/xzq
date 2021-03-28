using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExample4
{
    class JiSuan

    {
        int a;
        int b;
        int num;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int Num {  set => num = value; }

        public virtual void GetNum()
        {

        }
    }
}
