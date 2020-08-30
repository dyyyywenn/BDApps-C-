using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_30
{
    class PersegiPanjang : BangunDatar
    {
        public float panjang;
        public float lebar;

        public override float Luas()
        {
            float Luas = panjang * lebar;
            Console.WriteLine("Luasnya : " + Luas);
            return Luas;
        }
        public override float Keliling()
        {
            float Keliling = 2 * panjang + 2 * lebar;
            Console.WriteLine("Kelilingnya :" + Keliling);
            return Keliling;
        }
    }
}
