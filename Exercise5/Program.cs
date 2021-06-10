using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number of Rows");
            int last = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***********************************");
            for (int i = 1; i <= num; i++) {
                for (int j = 1; j <= i; j++) {
                    if (last == 0)
                    {
                        Console.Write('1');
                        last = 1;
                    }
                    else if (last == 1) {
                        Console.Write(0);
                        last = 0;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
