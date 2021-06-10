using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            int length = (int)Math.Pow(2, row - 1) + 1;
            String[] secondPart = new string[row];
            if (row == 1) { length = 1; }
            for (int i = 1; i <= row; i++) {
                char[] temp = new char[length];
                Array.Fill(temp, ' ');
                temp[temp.Length / 2] = '*';
                int currentRowLength= (int)Math.Pow(2, i - 1) + 1;
                if (i == 1) { currentRowLength = 1; }
                for (int j = 1; j <= (currentRowLength - 1) / 2; j++) {
                    temp[temp.Length / 2 + j] = '*';
                    temp[temp.Length / 2 - j] = '*';
                }
                String currentString = new String(temp);
                secondPart[i-1] = currentString;
                Console.WriteLine(new String(temp));
            }
            for (int i = row - 2; i >= 0; i--) {
                Console.WriteLine(secondPart[i]);
            }
        }
    }
}
