using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            string str = "qwertkeyboards=abcdefghijklmn";
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + "   "+str);
                //Thread.Sleep(100);
                //Console.WriteLine(i + "   " + str);
                //Thread.Sleep(100);
                //Console.WriteLine(i + "   " + str);
            }
            s.Stop();
            Console.WriteLine("time elapsed :" + s.ElapsedMilliseconds/1000);
            //Console.ReadKey();
            
        }
    }
}
