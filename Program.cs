using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vispro_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //String nama;
            //Console.Write("Masukkan nama anda : ");
            //nama = Console.ReadLine();
            //Console.WriteLine("Hallo {0}", nama);

            segitiga();
        }

        static void segitiga()
        {
            Console.WriteLine("Menu Segitiga");
            Console.WriteLine("1. Rata Kiri");
            Console.WriteLine("2. Rata Kanan");
            Console.WriteLine("3. Rata Tengah");

            Console.Write("Input angka : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void calculator()
        {
            try
            {

                int x, y, z;

                Console.WriteLine("Menu");
                Console.WriteLine("1. Tambah");
                Console.WriteLine("2. Kali");
                Console.WriteLine("3. Kurang");
                Console.WriteLine("4. Bagi");
                int pil = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Masukkan nilai 1 : ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukkan nilai 2 : ");
                y = Convert.ToInt32(Console.ReadLine());

                if (pil == 1)
                {
                    z = x + y;
                    Console.WriteLine("Hasil penjumlahan" +
                        " {0} + {1} = {2}", x, y, z);
                }
                else if (pil == 2)
                {
                    z = x * y;
                    Console.WriteLine("Hasil perkalian" +
                        " {0} + {1} = {2}", x, y, z);
                }
                else if (pil == 3)
                {
                    z = x - y;
                    Console.WriteLine("Hasil pengurangan" +
                        " {0} + {1} = {2}", x, y, z);
                }
                else if (pil == 4)
                {
                    z = x / y;
                    Console.WriteLine("Hasil pembagian" +
                        " {0} + {1} = {2}", x, y, z);
                }
                else
                {
                    Console.WriteLine("Operasi tidak ditemukan");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
