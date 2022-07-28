using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            System.Console.Write("Lütfen bir sayı giriniz");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if (i%2==1)
                {
                    System.Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki  tek ve çift sayıların kendi içlerinde toplamlarını yazdır
            int tekToplam=0;
            int ciftToplam=0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1)
                    tekToplam+=i;
                else
                    ciftToplam+=i;
            }
            System.Console.WriteLine("Teklerin toplamı:"+tekToplam);
            System.Console.WriteLine("Çiftlerin toplamı:"+ciftToplam);


            //break, continue
            for (int i = 1; i <= 10; i++)
            {
                if(i==4)
                    continue;
                if (i==9)
                    break;
                System.Console.WriteLine(i);
            }
        }
    }
}