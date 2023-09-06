using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP
{
    class ToaDo
    {
        private string tenTD;

        public void SetTenTD(string tenTD)
        {
            this.tenTD = tenTD;
        }
        public string GetTenTD() 
        {
            return this.tenTD;
        }
        private double x, y;

        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double GetX()
        {
            return this.x;
        }
        public double GetY()
        {
            return this.y;
        }
        public ToaDo()
        {
            this.tenTD = "ABC";
            this.x = 5;
            this.y = 5;
        }
        public ToaDo(string tentd,double x, double y)
        {
            this.tenTD = tentd;
            this.x = x;
            this.y = y;
        }
        public ToaDo(double x, double y)
        {
            this.tenTD = "defaulf";
            this.x = x;
            this.y = y;
        }
        public override string ToString(){
            String st = String.Format("{0}({1},{2})", tenTD, x, y);
            return st;
        }
    }
}
