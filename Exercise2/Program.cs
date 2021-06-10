using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic calculator = new Arithmetic();
            double result;
            Boolean flag = true;
            while (flag) {
                Console.WriteLine("Welcome to Calculator");
                Console.WriteLine("Usage: First Element +-*/ Second Element");
                Console.WriteLine("*****************************************************");
                Console.Write("Please enter first element:");
                String firstElement=Console.ReadLine();
                calculator.A = Convert.ToInt32(firstElement);
                Console.Write("Please enter first element:");
                String SecondElement = Console.ReadLine();
                calculator.B = Convert.ToInt32(SecondElement);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please enter the Operation you want to perform");
                Console.WriteLine("1:Addition\t2:substraction\t3:multiplication\t4:division\t5:exit");
                String operation = Console.ReadLine();
                int op = Convert.ToInt32(operation);
                switch (op) {
                    case 1:
                        result = calculator.addition();
                        Console.WriteLine($"result is {result}\n\n");
                        break;
                    case 2:
                        result = calculator.subtraction();
                        Console.WriteLine($"result is {result}\n\n");
                        break;
                    case 3:
                        result = calculator.multiplication();
                        Console.WriteLine($"result is {result}\n\n");
                        break;
                    case 4:
                        if (calculator.B == 0) {
                            Console.WriteLine("can't divide by 0, please enter another number\n\n");
                            break;
                        }
                        result = calculator.division();
                        Console.WriteLine($"result is {result}\n\n");
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
