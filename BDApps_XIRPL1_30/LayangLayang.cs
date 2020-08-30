using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_30
{
    class LayangLayang : BangunDatar
    {
        public float d1;
        public  float d2;
        public float sisi1;
        public float sisi2;

        public override float Luas()
        {
            float Luas = 1/2 * d1 * d2;
            Console.WriteLine("Luasnya:" + Luas);
            return Luas;
        }
        public override float Keliling()
        {
            float Keliling = 2 * (sisi1 * sisi2);
            Console.WriteLine("Kelilingnya:" + Keliling);
            return Keliling;
        }

    }
}
