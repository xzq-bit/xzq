using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("请输入要进行的运算：+ - * /");
            x = Convert.ToChar(Console.ReadLine());
            switch (x)
            {
                case '+':
                    {
                        Console.WriteLine("请输入序号进行何类运算1：字符2：数字");
                        int n;
                        n= Convert.ToInt32(Console.ReadLine());
                        if (n==1) 
                        {
                            Add a1 = new Add();
                            a1.C = Console.ReadLine();
                            a1.D = Console.ReadLine();
                            a1.GetNum();
                        }
                        else
                        {
                            Add a2 = new Add();
                            a2.A= Convert.ToInt32(Console.ReadLine());
                            a2.B= Convert.ToInt32(Console.ReadLine());
                            a2.GetNum();
                        }
                        
                    }break;
                case '-':
                    {
                        Console.WriteLine("请输入序号进行何类运算1：字符2：数字");
                        int m;
                        m = Convert.ToInt32(Console.ReadLine());
                        if(m==1)
                        {
                            Sub s1 = new Sub();
                            s1.Str= Console.ReadLine();
                            s1.Str1= Console.ReadLine();
                            s1.GetNum();
                        }
                        else
                        {
                            Sub s2 = new Sub();
                            s2.A= Convert.ToInt32(Console.ReadLine());
                            s2.B= Convert.ToInt32(Console.ReadLine());
                            s2.GetNum();
                        }
                        
                    }break;
                case '*':
                    {
                        Pur p1 = new Pur();
                        p1.A = Convert.ToInt32(Console.ReadLine());
                        p1.B = Convert.ToInt32(Console.ReadLine());
                        p1.GetNum();
                    }break;
                case '/':
                    {
                        Div d1 = new Div();
                        d1.A = Convert.ToInt32(Console.ReadLine());
                        d1.B = Convert.ToInt32(Console.ReadLine());
                        d1.GetNum();
                    }break;
            }
        }
    }
}
