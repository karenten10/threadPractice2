using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncHello2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            oneByOne();
        }

        static void oneByOne()
        {
            method1();
            method2();
        }

        static void method1()
        {
            Thread.Sleep(3000);
            Console.WriteLine($"method1 ===> " + DateTime.Now);
        }

        static void method2()
        {
            Thread.Sleep(3000);
            Console.WriteLine($"method2 ===> " + DateTime.Now);
        }
    }
}
