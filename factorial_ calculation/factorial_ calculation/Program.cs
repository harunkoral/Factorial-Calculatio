using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial__calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FACTORIAL CALCULATION (FAKTORİYEL HESAPLAMA)");

            

            int Fak = 1;

            for(;;)
            {
                Console.Write("Enter a number (Bir sayı giriniz) : ");
                int Sayi = Convert.ToInt32(Console.ReadLine());

                if (Sayi < 0)
                {
                    Console.WriteLine("I can't process the number you wrote. " +
                        "Your number must be greater than 0(Zero)!!" +
                        "(Yazdığınız sayı için işlem yapamam. Sayınız 0(Sıfırdan) büyük olmalı!!)");
                }
                else if (Sayi == 0)
                {
                    Console.WriteLine("The number you choose is 0. Its factorial is 1." +
                        "(Seçtiğiniz sayı 0'dır. Faktoriyeli 1'dir.)");
                }
                else
                {
                    for (int i = 1; i <= Sayi; i++)
                    {
                        Fak *= i;
                        Console.WriteLine($" Numbers (Sayılar):  {i}");

                    }
                    Console.WriteLine($"{Fak} It is factorial (Faktoriyeldir).");
                }

                Console.Write("Continue (Devam edilsin mi)? (Y/N)");
                string Devam = Console.ReadLine();

                if(Devam == "Y" || Devam == "y")
                {
                    continue;
                }
                else if (Devam == "N" || Devam == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please press Y or N (Lütfen Y veya N harflerine basınız)!!");
                }
            }

            Console.ReadLine();
        }
    }
}
