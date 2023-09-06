using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP
{
    class SinhVien
    {
        private int maSV;

        public int MaSV
        {
            get { return maSV; }
            set { if (maSV > 0) maSV = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { if(hoTen != null) hoTen = value; }
        }
        private double diemTH;

        public double DiemTH
        {
            get { return diemTH; }
            set { if(0<=diemTH && diemTH<=10) diemTH = value; }
        }
        private double diemLT;

        public double DiemLT
        {
            get { return diemLT; }
            set { if(0<=diemLT && diemLT<=10) diemLT = value; }
        }
        public SinhVien()
        {
            this.maSV = 100;
            this.hoTen = "Dang Cho";
            this.diemLT = 5;
            this.diemTH = 10;
        }
        public SinhVien(int maSV, string hoTen, double dlt, double dth)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diemLT = dlt;
            this.diemTH = dth;
        }
        public double DTB()
        {
            return (DiemLT + DiemTH) / 2;
        }
        public override string ToString()
        {
            String st = String.Format("{0}/t{1}/t{2}/t{3}/t{4}", MaSV, HoTen, DiemLT, DiemTH, DTB());
            return st;
        }
    }
}
