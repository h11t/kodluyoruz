using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustip metot_adi(parametreListesi/arguman)
            //{
                //komutlar;
            //}

            int a=2;
            int b=3;
            Console.WriteLine(a+b);
            Console.WriteLine(Topla(a,b));

            Metotlar ornek=new Metotlar();
            ornek.EkranaYazdir(Topla(a,b).ToString());
            ornek.EkranaYazdir(Convert.ToString(Topla(a,b)));

            int sonuc2=ornek.ArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir(Topla(a,b).ToString());
            
        }
        static int Topla(int deger1,int deger2)
        {
            return deger1+deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }

}


