using System;
using System.Threading;

namespace ThreadPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ===> " + DateTime.Now);
            thread1();
        }

        static void thread1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("2 ===> " + DateTime.Now);
        }
    }
}
