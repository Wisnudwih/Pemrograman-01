using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsolAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wisnu Dwi Handono//
            
            int a, b;
            int pilih;
            Console.Title = "Aplikasi Calculator";

            Console.Write("Pilih menu calculator:");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("1.Penjumlahan");
            Console.WriteLine();
            Console.Write("2.Pengurangan");
            Console.WriteLine();
            Console.Write("3.perkalian");
            Console.WriteLine();
            Console.Write("4.pembagian");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Input nomer menu[1..4] :");

            pilih = int.Parse(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    Console.Write("Inputkan nilai a : ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    b = (int)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Penjumlahan " + (a + b));
                    Console.WriteLine();
                    Console.WriteLine("Tekan sembarang Key uuntuk keluar");
                    break;
                case 2:
                    Console.Write("Inputkan nilai a : ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    b = (int)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pengurangan " + (a - b));
                    Console.WriteLine();
                    Console.WriteLine("Tekan sembarang Key uuntuk keluar");
                    break;
                case 3:
                    Console.Write("Inputkan nilai a : ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    b = (int)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Perkalian " + (a * b));
                    Console.WriteLine();
                    Console.WriteLine("Tilih sembarang Key uuntuk keluar");
                    break;
                case 4:
                    Console.Write("Inputkan nilai a : ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    b = (int)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pembagian " + (a / b));
                    Console.WriteLine();
                    Console.WriteLine("Tekan sembarang Key uuntuk keluar");
                    break;
                default:
                    Console.WriteLine("Maaf,menu yang anda pilih tidak tersedia");
                    Console.WriteLine();
                    Console.WriteLine("Pilih sembarang Key uuntuk keluar");
                    break;

            }
            Console.ReadKey();
        }
    }
}





/* Console.Write("Inputkan nilai a = ");
 int a = int.Parse(Console.ReadLine());//proses casting

 Console.Write("Inputkan nilai b = ");
 int b = Convert.ToInt32(Console.ReadLine());//proses casting

 Console.WriteLine();*/

/* Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
 Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
 Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
 Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

 Console.WriteLine("\ntekan sembarang KEY untuk keluar");
 Console.ReadKey();*/



/* static int penambahan(int a,int b)
 {
     return a + b;
 }

 static int pengurangan(int a,int b)
 {
     return a - b;
 }

 static int perkalian(int a,int b)
 { 
     return a * b;
 }

 static int pembagian(int a,int b)
 {
     return a / b;
 }


}
}*/
