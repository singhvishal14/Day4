using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        //int num1, num2;
                        //Console.WriteLine("Enter First Number");
                        num1 = int.Parse(Console.ReadLine());
                        //Console.WriteLine("Enter Second Number");
                        num2 = int.Parse(Console.ReadLine());
                        var res = num1 > num2 ? "First Number is greater" : "Second Number is greter";
                        Console.WriteLine(res);
                        Console.ReadKey();
            */
            int pre,final;
            Console.WriteLine("Enter Pre Marks");
            pre = int.Parse(Console.ReadLine());
            if(pre > 60)
            {
                Console.WriteLine("Enter Final Marks");
                final = int.Parse(Console.ReadLine());
                if(final > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
            else
            {
                Console.WriteLine("Failed in Pre");
            }
            Console.ReadKey();

        }
    }
}
