using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithi_Cau2_NguyenMinhKhang_02PM16B1D1
{
    internal class Manager : Employee
    {

        string teamsize;

        public string Teamsize { get => teamsize; set => teamsize = value; }

        public Manager() { }

        public Manager(string hoten, string msnv, string chucvu, double luong,string teamsize)
            :base(hoten,msnv, chucvu,luong)
        {
            this.teamsize = teamsize;
        }
    }
}
