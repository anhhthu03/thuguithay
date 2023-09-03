using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btlythuyet { 
    public class Bai8
    {
        private string title;
        public string TITTLE { get { return title; } set { title = value; } }

        static void Main(string[] args)
        {
            Bai8 b8p = new Bai8();
            b8p.TITTLE = "Microsoft";
            Console.Write("Title: ", b8p.TITTLE);

            Console.Read();
        }
    }
}