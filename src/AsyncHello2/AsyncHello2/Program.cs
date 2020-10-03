using System;
using System.Threading.Tasks;

namespace AsyncHello2 { 
    class Program
{
    static void Main(string[] args)
    {
        Method1();
        Method2();
        Console.ReadKey();
    }

    public static async Task Method1()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" M1");
            }
        });
    }


    public static void Method2()
    {
        for (int i = 0; i < 25; i++)
        {
            Console.Write(" M2");
        }
    }
}

}