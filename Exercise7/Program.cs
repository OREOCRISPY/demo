using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Account customer = new Account();
            Console.WriteLine("Please Enter Your Pin:");
            String inputPin = Console.ReadLine();
            if (customer.CheckPin(inputPin)) {
                Boolean flag = true;
                while (flag)
                {
                    Console.WriteLine("********Welcome to ATM Service**************");
                    Console.WriteLine("\n1. Check Balance\n2.Withdraw Cash\n3.Deposit Cash\n4.Quit\n");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Enter Your Choice:");
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine($"You're balance in Rs:{customer.CheckBalance()}");
                            break;
                        case 2:
                            Console.WriteLine("Enter the amount");
                            int withdrawAmount =Convert.ToInt32(Console.ReadLine());
                            String withdrawMsg;
                            customer.WithdrawCash(withdrawAmount, out withdrawMsg);
                            Console.WriteLine(withdrawMsg);
                            break;
                        case 3:
                            Console.WriteLine("Enter the amount");
                            int depositAmount = Convert.ToInt32(Console.ReadLine());
                            String depositMsg;
                            customer.DepositCash(depositAmount,out depositMsg);
                            Console.WriteLine(depositMsg);
                            break;
                        case 4:
                            flag = false;
                            break;
                    }
                }
            }
        }
    }
}
