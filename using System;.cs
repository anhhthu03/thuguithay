using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace btlythuyet

{

    class NhanVien :nguoi

    {

        private string bangcap;

        public NhanVien(string maso, string hoten, string gioitinh, string bangcap)

         : base(maso, hoten, gioitinh)

        {

            this.bangcap = bangcap;

        }

        public sealed override void Nhap()

        {

            base.Nhap(); 

            Console.Write("Nhap thong tin bang cap: ");

            bangcap = Console.ReadLine();

        }

        public override void HienThi()

        {

            base.HienThi();

            Console.WriteLine("Bang cap: {0}", bangcap);

        }

    }

}