using System;

namespace BDApps_XIRPL1_30
{
    class Program
    {
        static void quit()
        {
            System.Environment.Exit(0);
        }

        static int menu()
        {
            Console.WriteLine("=======Mari Menghitung Luas Dan Bangun Datar=======");
            Console.WriteLine("1.Persegi");
            Console.WriteLine("2.Persegi Panjang");
            Console.WriteLine("3.Segitiga");
            Console.WriteLine("4.Jajar Genjang");
            Console.WriteLine("5.Trapezium");
            Console.WriteLine("6.Layang-layang");
            Console.WriteLine("7.Belah ketupat");
            Console.Write("Pilihan Anda : ");
            int pil = Convert.ToInt32(Console.ReadLine());

            return pil;
        }

        static void Main()
        {
            BangunDatar bangundatar = new BangunDatar();
            bangundatar.Luas();
            bangundatar.Keliling();

            int pill = menu();
            Console.WriteLine();

            if (pill == 1)
            {
                Persegi persegi = new Persegi();
                Console.Write("Masukan sisi : ");
                float input = float.Parse(Console.ReadLine());
                persegi.sisi = input;

                persegi.Luas();
                persegi.Keliling();

                Console.Write("\n\nContinue? Ya/No:");
                string Ya = Console.ReadLine();
                if ((Ya == "Ya") | (Ya == "Ya"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 2)
            {
                PersegiPanjang persegiPanjang = new PersegiPanjang();
                Console.Write("Masukan sisi panjang : ");
                float inputp = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi lebar:");
                float inputl = float.Parse(Console.ReadLine());
                persegiPanjang.panjang = inputp;
                persegiPanjang.lebar = inputl;

                persegiPanjang.Luas();
                persegiPanjang.Keliling();

                Console.Write("\n\nContinue? Ya/No:");
                string Ya = Console.ReadLine();
                if ((Ya == "Ya") | (Ya == "Ya"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 3)
            {
                Segitiga segitiga = new Segitiga();
                Console.Write("Masukan panjang alas : ");
                float inputa = float.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi segitiga : ");
                float inputt = float.Parse(Console.ReadLine());
                segitiga.alas = inputa;
                segitiga.tinggi = inputt;

                segitiga.Luas();
                segitiga.Keliling();

                Console.Write("\n\nContinue? Ya/No:");
                string Ya = Console.ReadLine();
                if ((Ya == "Ya") | (Ya == "Ya"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 4)
            {
                JajarGenjang jajargenjang = new JajarGenjang();
                Console.Write("Masukan sisi miring : ");
                float inputm = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi bawah : ");
                float inputb = float.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi jajargenjang : ");
                float inputt = float.Parse(Console.ReadLine());

                jajargenjang.sisiMiring = inputm;
                jajargenjang.Alas = inputb;
                jajargenjang.Tinggi = inputt;

                jajargenjang.Luas();
                jajargenjang.Keliling();

                Console.Write("\n\nContinue? y/n:");
                string Ya = Console.ReadLine();
                if ((Ya == "Ya") | (Ya == "Ya"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 5)
            {
                Trapezium trapesium = new Trapezium();
                Console.Write("Masukan sisi A : ");
                float inputm = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi B : ");
                float inputa = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi C : ");
                float inputb = float.Parse(Console.ReadLine());
                Console.Write("Masukan  sisi D: ");
                float inputc = float.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi trapesium : ");
                float inputt = float.Parse(Console.ReadLine());

                trapesium.sisiA = inputm;
                trapesium.sisiB = inputa;
                trapesium.sisiC = inputb;
                trapesium.sisiD = inputc;
                trapesium.Tinggi = inputt;

                trapesium.Luas();
                trapesium.Keliling();

                Console.Write("\n\nContinue? Ya/No:");
                string Ya = Console.ReadLine();
                if ((Ya == "Ya") | (Ya == "Ya"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 6)
            {
                LayangLayang layangLayang = new LayangLayang();
                Console.Write("Masukan sisi atas : ");
                float inputa = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi bawah : ");
                float inputb = float.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 1 : ");
                float inputd1 = float.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 2 : ");
                float inputd2 = float.Parse(Console.ReadLine());

                layangLayang.sisi1 = inputa;
                layangLayang.sisi2 = inputb;
                layangLayang.d1 = inputd1;
                layangLayang.d2 = inputd2;

                layangLayang.Luas();
                layangLayang.Keliling();

                Console.Write("\n\nContinue? Ya/No:");
                string Ya = Console.ReadLine();
                if ((Ya == "Ya") | (Ya == "Ya"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }

            }
            else if (pill == 7)
            {
                BelahKetupat belahketupat = new BelahKetupat();
                Console.Write("Masukan sisi : ");
                float input = float.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 1 : ");
                float inputd1 = float.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 2 : ");
                float inputd2 = float.Parse(Console.ReadLine());

                belahketupat.sisi = input;
                belahketupat.d1 = inputd1;
                belahketupat.d2 = inputd2;

                belahketupat.Luas();
                belahketupat.Keliling();

                Console.Write("\n\nContinue? Ya/No:");
                string Ya = Console.ReadLine();
                if ((Ya == "Ya") | (Ya == "Ya"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }

            else
            {
                System.Console.Clear();
                Console.WriteLine("Menu Tidak tersedia");
                Main();
            }
        }
    } 
}
