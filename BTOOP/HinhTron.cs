using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP
{
    class HinhTron
    {       
        private ToaDo tam;
        public void SetTam(ToaDo tam)
        {
            this.tam = tam;
        }
        public ToaDo GetTam()
        {
            return this.tam;
        }

        private double banKinh;
        public void SetBanKinh(double bk)
        {
            this.banKinh = bk;
        }
        public double GetBanKinh()
        {
            return this.banKinh;
        }

        public HinhTron()
        {
            this.tam = new ToaDo(3, 9);
            this.banKinh = 7;
        }
        public HinhTron(ToaDo td,double bk)
        {
            this.tam = td;
            this.banKinh = bk;
        }

        public double TinhChuVi()
        {
            return 2 * banKinh * Math.PI;
        }
        public double TinhDienTich()
        {
            return banKinh * banKinh * Math.PI;
        }
        public override string ToString()
        {
            String st = String.Format("Tam:{0} BanKinh:{1} ChuVi:{2} DienTich:{3}", tam, banKinh, TinhChuVi(), TinhDienTich());
            return st;
        }
    }
}
