using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3_Break_Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach statement example");
            int[] intArr = new int[10];
            Random r = new Random();
            
            for (int idx = 0; idx < 10; idx++)
            {
                intArr[idx] = r.Next(1, 10);
            }
            
            Console.Write("Value of element: ");
            foreach (int val in intArr)
            {
                Console.Write(val + " ");
            }
            Console.Read();
        }


    }
}