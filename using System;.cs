using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3_for_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For statement example");

            for (int idx = 10; idx > 0; idx--)
            {
                Console.Write(idx + " ");
            }
            Console.Read();
        }
    }
}