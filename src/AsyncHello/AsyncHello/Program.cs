using System;
using System.Threading.Tasks;

namespace AsyncHello
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("1 ======> " + DateTime.Now);

            var number1 = await getNumber1();

            var number2 = await getNumber2();

            var result = number1 + number2;

            Console.WriteLine("2 ======> " + DateTime.Now);

            Console.WriteLine($"======> result => {result}");
        }

        static Task<int> getNumber1()
        {
            return Task.Run(()=> {
                return 100;
            });
        }

        static Task<int> getNumber2()
        {
            return Task.Run(() => {
                return 200;
            });
        }
    }
}
