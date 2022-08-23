//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System.Collections;
using System.Text.RegularExpressions;

ArrayList asalSayi=new ArrayList();
ArrayList asalSayiOlmayan=new ArrayList();
Regex desen = new Regex("^[0-9]*$");

byte sayac=1;
while(sayac<21)
{
    Console.Write($"{sayac}. sayıyı giriniz",sayac);
    string sayi=Console.ReadLine();

    if(!desen.IsMatch(sayi)|| Convert.ToInt32(sayi)<=0)
    {
        Console.WriteLine("Sayı geçersizdir. Lütfen negatif sayı ya da harf girmeyin");
    }
    else
    {
        int sayi1=Convert.ToInt32(sayi);
        byte sonuc=(byte)Asalmi(sayi1);
        if(sonuc==1)
        {
            asalSayi.Add(sayi1);            
        }
        else
        {
            asalSayiOlmayan.Add(sayi1);
        }
        sayac++;
    }
}
int asalToplam = 0;
int asalDegilToplam = 0;
asalSayi.Sort();
asalSayiOlmayan.Sort();
asalSayi.Reverse();
asalSayiOlmayan.Reverse();
Console.WriteLine("Asal sayıların büyükten küçüğe gösterimi");
foreach (int item in asalSayi)
{
    Console.WriteLine(item);
    asalToplam+=item;
}
Console.WriteLine("Asal olmayan sayıların büyükten küçüğe gösterimi");
foreach (int item in asalSayiOlmayan)
{
    Console.WriteLine(item);
    asalDegilToplam+=item;
}

Console.WriteLine($"Asal sayılar şu kadardır:{asalSayi.Count}" );
Console.WriteLine($"Asal olmayan sayılar şu kadardır:{asalSayiOlmayan.Count}");
Console.WriteLine($"Asal sayıların ortalaması:{asalToplam/asalSayi.Count}");
Console.WriteLine($"Asal olmayan sayıların ortalaması:{asalDegilToplam/asalSayiOlmayan.Count}");


static int Asalmi(int sayi)
{
    int i;
    for (i = 2; i <= sayi - 1; i++)
    {
        if (sayi % i == 0)
        {
            return 0;
        }
    }
    if (i == sayi)
    {
        return 1;
    }
    return 0;
}




