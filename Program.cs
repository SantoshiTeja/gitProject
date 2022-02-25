using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fun1();
            fun2();
            string name ;
            Console.WriteLine("Enter ur name");
            name =  Console.ReadLine();
            //Console.Read();


        }
        static async void fun1()
        {
            await Task.Delay(20000);
            Console.WriteLine("Downloadind first file");
        }
        static async void fun2()
        {
            await Task.Delay(20000);
            Console.WriteLine("Dowlaoding secound file");
        }
    }
}
