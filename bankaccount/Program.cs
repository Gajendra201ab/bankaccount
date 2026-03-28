using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("create account:--");
            Console.WriteLine("enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter account number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter initial balance:");
            int bal=int.Parse(Console.ReadLine());
            Console.WriteLine("enter a pin");
            int p=int.Parse(Console.ReadLine());
            Console.WriteLine("select options");
            Console.WriteLine("1.deposit");
            Console.WriteLine("2.withdraw");
            int opt=int.Parse(Console.ReadLine());
            switch(opt)
            {
                    case 1:
                    Console.WriteLine("enter pin");
                    int pin=int.Parse(Console.ReadLine());
                    if (p == pin)
                    {
                        Console.WriteLine("enter amount to deposit");
                        int d = int.Parse(Console.ReadLine());
                        bal += d;
                        Console.WriteLine("total balance is" + bal);
                    }
                    else { Console.WriteLine("wrong pin"); }
                        break;
                    case 2:
                    Console.WriteLine("enter pin");
                    pin=int.Parse(Console.ReadLine());
                    if (p == pin)
                    {
                        Console.WriteLine("enter amount to witdraw ");
                        int w = int.Parse(Console.ReadLine());
                        bal -= w;
                    }
                    else { Console.WriteLine("wrong pin"); }
                        break;
                    default:
                    Console.WriteLine("invalid option");
                    break;

            }
        }
    }
}
