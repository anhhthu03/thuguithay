using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLyThuyet
{
    internal class Bai3ContinueExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Continue statement example");
            for (int idx = 1; idx <= 10; idx++)
            {
                if (idx % 2 == 0)
                {
                    continue;
                }
                Console.Write(idx + " ");
            }
            Console.Read();
        }
            
        }
    }
