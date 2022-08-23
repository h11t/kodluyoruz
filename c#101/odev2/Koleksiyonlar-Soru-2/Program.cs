/*
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
*/

using System.Text.RegularExpressions;

Regex desen = new Regex("^[0-9]*$");
byte sayac=1;
int[] sayidizisi=new int[20];
while(sayac<21)
{
    Console.Write($"{sayac}. sayıyı giriniz",sayac);
    string sayi=Console.ReadLine();

    if(!desen.IsMatch(sayi))
    {
        Console.WriteLine("Sayı geçersizdir. Lütfen  harf girmeyin");
    }
    else
    {
        int sayi1=Convert.ToInt32(sayi);        
        sayidizisi[sayac-1]=sayi1;
        sayac++;
    }
}

int[] enbuyukler=new int[3];
int[] enkucukler=new int[3];
int enbuyuktoplam=0;
int enkucuktoplam=0;

Array.Sort(sayidizisi);
foreach (var item in sayidizisi)
{
    Console.WriteLine(item);
}
for (int i = 0; i < 3; i++)
{
    enkucukler[i]=sayidizisi[i];
    enbuyukler[i]=sayidizisi[19-i];
    enkucuktoplam+=sayidizisi[i];
    enbuyuktoplam+=sayidizisi[19-i];
}

Console.WriteLine($"en büyüklerin ortalaması{enbuyuktoplam/3}");
Console.WriteLine($"en küçüklerin ortalaması{enkucuktoplam/3}");
Console.WriteLine($"ortalamaların toplamı{enbuyuktoplam+enkucuktoplam}");




