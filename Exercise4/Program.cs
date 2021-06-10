using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList res = new System.Collections.ArrayList();
            Console.WriteLine("Please enter the start position:");
            long start = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter the end position:");
            long end = Convert.ToInt64(Console.ReadLine());
            while (start < 0 || end < 0)
            {
                Console.WriteLine("illegal input");
                return;
            }
            for(long i = start; i <= end; i++)
            {
                char[] temp = ("" + i).ToCharArray();
                long check = 0;
                for (int j = 0; j < temp.Length; j++) {
                    check += (long)Math.Pow(temp[j]-'0',temp.Length);
                }
                if (check == i) {
                    res.Add(i);
                }
            }
            for (int i = 0; i < res.Count; i++) {
                Console.WriteLine(res[i]);
            }
        }
    }
}
