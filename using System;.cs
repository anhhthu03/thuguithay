using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bait4
    {
        static void Main(string[] args)
        {
            int[] intA = { 3, 7, 1, 4, 2, 0, 11 };
            int[] tempA = intA;
            Console.Write("Elements of array: ");
            foreach (int i in intA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
           
            Array.Reverse(tempA);
            Console.Write("Array after reversed: ");
            foreach (int i in tempA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
          
            Array.Sort(intA);
            Console.Write("Array after sorted: ");
            foreach (int i in intA)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}