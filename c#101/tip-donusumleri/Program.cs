// See https://aka.ms/new-console-template for more information


using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implcit Conversion(Bilinçsiz Dönüşüm) düşük->yüksek
            System.Console.WriteLine("****Implcit Conversion(Bilinçli Dönüşüm)****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            System.Console.WriteLine("d:"+d);

            long h=d;
            System.Console.WriteLine("h:"+h);

            float i=h;
            System.Console.WriteLine("i:"+i);

            string e="hilal";
            char f='k';
            object g=e+f+d;
            System.Console.WriteLine("g:"+g);

            //Explicit Conversion(Bilinçli Dönüşüm)
            System.Console.WriteLine("****Explicit Conversion(Bilinçli Dönüşüm)****");
            int x=4;
            byte y=(byte)x;
            System.Console.WriteLine("y:" +y);

            int z=100;
            byte t=(byte)z;
            System.Console.WriteLine("t:"+t);

            float w=10.3f;
            byte v=(byte)w;
            System.Console.WriteLine("v:"+v);

            // ***ToString Methodu ***
             System.Console.WriteLine("****ToString Methodu****");
             int xx=6;
             string yy=xx.ToString();
             System.Console.WriteLine("yy:"+yy);

             string zz=12.5f.ToString();
             System.Console.WriteLine("zz:"+zz);

             //System.Convert
             System.Console.WriteLine("****System.Convert Sınıfı****");
            string s1="10", s2="20";
            int sayi1, sayi2;
            int toplam;

            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);
            toplam=sayi1+sayi2;
            Console.WriteLine("toplam:"+toplam);

            //Pars string ifadeleri dönüştürmek için kullanılır
             System.Console.WriteLine("****Pars****");
             ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1="10";
            string metin2="10.25";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            double1=Double.Parse(metin2);
            System.Console.WriteLine("rakam1:"+rakam1);
            System.Console.WriteLine("double1:"+double1);
        }
    }
}
