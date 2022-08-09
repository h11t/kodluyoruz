// See https://aka.ms/new-console-template for more information

//out parametreler
string sayi="999";

bool sonuc=int.TryParse(sayi,out int outsayi);
if (sonuc)
{
    Console.WriteLine("başarılı");
    Console.WriteLine(outsayi);
}
else
{
    Console.WriteLine("başarısız");

}

Metotlar instance=new Metotlar();
instance.Topla(2,3,out int toplamSonuc);
Console.WriteLine(toplamSonuc);

//metot aşırı yükleme - overloading
int ifade=999;
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
instance.EkranaYazdir("Hilal","Tekdem");

//metot imazası= metotadi+parametre sayisi+ parametre tipi
//erişim belirteci imzaya dahil değildir. aynı imzalı public ve private metotları için hata verir


