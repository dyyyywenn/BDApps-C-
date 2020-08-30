using System;
using System.Collections.Generic;
using System.Text;

namespace BDApps_XIRPL1_30
{
    class BelahKetupat : BangunDatar
    {
        //atribut 
        public float d1;
        public float d2;
        public float sisi;

        //menthod luas dan keliling
        public override float Luas()
        {
            float Luas = 1/2 * d1 * d2;
            Console.WriteLine("Luasnya:" + Luas);
            return Luas;


        }
        public override float Keliling()
        {
            float Keliling = sisi * 4;
            Console.WriteLine("Kelilingnya:" + Keliling);
            return Keliling;
        }
    }
}   
