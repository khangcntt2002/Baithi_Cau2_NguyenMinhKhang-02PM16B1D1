using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithi_Cau2_NguyenMinhKhang_02PM16B1D1
{
    internal class Employee
    {
        string hoten;
        string msnv;
        string chucvu;
        double luong;

        public string Hoten { get => hoten; set => hoten = value; }
        public string Msnv { get => msnv; set => msnv = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public double Luong { get => luong; set => luong = value; }

        public Employee() { }

        public Employee(string hoten,string msnv,string chucvu,double luong) 
        { 

            this.chucvu = chucvu;
            this.hoten = hoten;
            this.msnv = msnv;
            this.luong = luong;
        }
    }
}
