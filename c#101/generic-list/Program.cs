using System.Collections.Generic;
using generic_list;

//List<T> class
//System.Cllections.Generic
//T -> object türündedir.

List<int> sayiListe=new();
sayiListe.Add(23);
sayiListe.Add(4);
sayiListe.Add(5);
sayiListe.Add(92);
sayiListe.Add(34);

List<string> renkListesi=new();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");


//Count
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListe.Count);

foreach (var sayi in sayiListe)
{
    Console.WriteLine(sayi);
}
foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);    
}

sayiListe.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));

//Listeden eleman çıkarma
sayiListe.Remove(4);
renkListesi.Remove("Yeşil");
sayiListe.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));

sayiListe.RemoveAt(0);//0.indeksteki eleman çıkarılır
renkListesi.RemoveAt(1);
sayiListe.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));

//Liste içerisinde arama
if(sayiListe.Contains(10))
Console.WriteLine("10 liste içerisinde bulundu");
else
Console.WriteLine("10 liste içerisinde bulunamadı");

//Eleman ile indexe erişme
Console.WriteLine(renkListesi.BinarySearch("Sarı"));
Console.WriteLine(renkListesi.BinarySearch("Turuncu"));
Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));
Console.WriteLine(renkListesi.BinarySearch("Mavi"));


//Diziyi listeye çevirme
string[] hayvanlar={"Kedi","Köpek","Kuş"};
List<string> hayvanlistesi=new List<string>(hayvanlar);

//Listeyi nasıl temizleriz?
hayvanlistesi.Clear();

//List içerisinde nesne tutma
List<Kullanıcılar> kullaniciListesi=new List<Kullanıcılar>();
Kullanıcılar kullanici1=new();
kullanici1.isim="Ayşe";
kullanici1.soyisim="Yılmaz";
kullanici1.yas=26;
Kullanıcılar kullanici2=new();
kullanici2.isim="Özcan";
kullanici2.soyisim="Çalışkan";
kullanici2.yas=26;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);
kullaniciListesi.Add(new Kullanıcılar{isim="Deniz", soyisim="Arda", yas=24});

kullaniciListesi.ForEach(kullanici=>Console.WriteLine(kullanici.isim+" "+ kullanici.soyisim+" "+kullanici.yas));





