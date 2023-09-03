using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3_dowhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do...While statement example");
            int n;
            do
            {
                Console.Write("Please input your number: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            Console.Write("Alright");
            Console.Read();
        }
    }
}