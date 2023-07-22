using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanlthpc07042_Lab5
{
    abstract public class SinhVien
    {
        public string hoTen;
        abstract public double getdiemTB();
    }
    public class SvCSharp : SinhVien
    {
        public double diemLab;
        public double diemASM;
        public double diemQuiz;

        public SvCSharp(double diemLab, double diemASM, double diemQuiz)
        {
            this.diemLab = diemLab;
            this.diemASM = diemASM;
            this.diemQuiz = diemQuiz;
        }

        public override double getdiemTB()
        {
            return (diemLab + diemQuiz * 8 + diemASM * 3) / 19;
        }
    }
    public class SvWeb : SinhVien
    {
        public double diemLab;
        public double diemASM;
        public double diemOnline;

        public SvWeb(double diemLab, double diemASM, double diemOnline)
        {
            this.diemLab = diemLab;
            this.diemASM = diemASM;
            this.diemOnline = diemOnline;
        }

        public override double getdiemTB()
        {
            return (diemLab * 4 + diemASM * 3 + diemOnline) / 8;
        }
    }
}
