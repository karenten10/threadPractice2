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
            // RunAsync();
        }

        static async Task RunAsync()
        {
            var int1 = Function1();

            var int2 = Function2();

            var int3 = Function3();

            Console.WriteLine($"===> int1 => {int1}");
            Console.WriteLine($"===> int2 => {int2}");
            Console.WriteLine($"===> int3 => {int3}");
        }

        static Task<int> Function1()
        {
            Console.WriteLine($"Function1 => a " + DateTime.Now);
            Thread.Sleep(5000);
            return Task.Run(() =>
            {
                Console.WriteLine($"Function1 => b " + DateTime.Now);

                return 1;
            });
        }

        static Task<int> Function2()
        {
            Console.WriteLine($"Function2 => a " + DateTime.Now);
            Thread.Sleep(5000);
            return Task.Run(() =>
            {
                Console.WriteLine($"Function2 => b " + DateTime.Now);

                return 1;
            });
        }

        static Task<int> Function3()
        {
            Console.WriteLine($"Function3 => a " + DateTime.Now);
            Thread.Sleep(5000);
            return Task.Run(() =>
            {
                Console.WriteLine($"Function3 => b " + DateTime.Now);

                return 1;
            });
        }

        static void oneByOne()
        {
            method1();
            method2();
            method3();
        }

        static void method1()
        {
            // Task.Delay(3000);
            Thread.Sleep(3000);
            Console.WriteLine($"method1 ===> " + DateTime.Now);
        }

        static void method2()
        {
            //Task.Delay(3000);
            Thread.Sleep(3000);
            Console.WriteLine($"method2 ===> " + DateTime.Now);
        }

        static void method3()
        {
            //Task.Delay(3000);
            Thread.Sleep(3000);
            Console.WriteLine($"method3 ===> " + DateTime.Now);

        }
    }
}
