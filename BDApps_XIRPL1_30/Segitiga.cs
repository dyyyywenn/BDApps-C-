using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_30
{
    class Segitiga : BangunDatar
    {
        public float alas;
        public float tinggi;

        public override float Luas()
        {
            float Luas = 1 / 2 * (alas * tinggi);
            Console.WriteLine("Luas Segitiga :" + Luas);
            return Luas;
        }
    }
}
