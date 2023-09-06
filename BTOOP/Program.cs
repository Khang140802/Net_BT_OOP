using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo a = new ToaDo("R", 5, 5);
            Console.WriteLine(a.ToString());
            HinhTron ht = new HinhTron(a, 10.5);
            Console.WriteLine(ht.ToString());
            Console.ReadLine();
        }
    }
}
