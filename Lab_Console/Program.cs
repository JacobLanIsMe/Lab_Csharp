using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;

namespace Lab_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            Console.Write("請輸入名字: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            Console.ReadKey();
            MyFirstClass mc = new MyFirstClass();
            mc.Method06();
        }
    }
}
