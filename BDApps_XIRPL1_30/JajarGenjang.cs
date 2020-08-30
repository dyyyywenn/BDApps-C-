using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_30
{
    class JajarGenjang : BangunDatar
    {
        public float Alas;
        public float Tinggi;
        public float sisiMiring;

        public override float Luas()
        {
            float Luas = Alas * Tinggi;
            Console.WriteLine("Luasnya:" + Luas);
            return Luas;

        }
        public override float Keliling()
        {
            float Keliling = 2 * (Alas + sisiMiring);
            Console.WriteLine("Kelilingnya:" + Keliling);
            return Keliling;
        }
    }
}
