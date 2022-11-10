using System;
namespace Odd_EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. OddEven Number" + "\n" + "2. PosNeg Number" + "\n" + "3. Exit");

                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Odd_Even oe = new Odd_Even();
                        oe.OddEve();
                        break;
                    case 2:
                        NumberSort num = new NumberSort();
                        num.sort();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
        }
}