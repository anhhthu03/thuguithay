using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BTLyThuyet
{
    internal class bai3whileloop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While statement example");
            int i = 1;
            while (i <= 5)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.Read();
        }
    }
}
