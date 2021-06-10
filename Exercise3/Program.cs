using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your String");
            String inputString=Console.ReadLine();
            String[] temp=inputString.Split(" ");
            String res = "";
            for (int i = temp.Length-1; i>=0; i--) {
                res = res + " " + temp[i];
            }
            res=res.Trim();
            Console.WriteLine("This is your result: "+res);
        }
    }
}
