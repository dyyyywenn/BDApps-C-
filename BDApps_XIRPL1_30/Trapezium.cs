using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_30
{
    class Trapezium : BangunDatar
    {
        public float Tinggi;
        public float sisiA;
        public float sisiB;
        public float sisiC;
        public float sisiD;

        public override float Luas()
        {
            float Luas = (sisiA + sisiB) * Tinggi / 2;
            Console.WriteLine("Luasnya:" + Luas);
            return Luas;
        }
        public override float Keliling()
        {
            float Keliling = sisiA + sisiB + sisiC + sisiD;
            Console.WriteLine("Kelilingnya:" + Keliling);
            return Keliling;
        }
    }
}
