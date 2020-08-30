using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_30
{
    class Persegi : BangunDatar
    {
        public float sisi;

        public override float Luas()
        {
            float Luas = sisi * sisi;
            Console.WriteLine("Luasnya : " + Luas);
            return Luas;
        }
        public override float Keliling()
        {
            float Keliling = sisi * 4;
            Console.WriteLine("Kelilingnya : " + Keliling);
            return Keliling;
        }
    }
}
