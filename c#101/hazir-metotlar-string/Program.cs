// See https://aka.ms/new-console-template for more information

string degisken="Dersimiz CSharp, Hoşgeldiniz!";
string degisken2="dersimiz CSharp, Hoşgeldiniz!";
string degisken3="CSharp";


Console.WriteLine(degisken.Length);

Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

//Concat
Console.WriteLine(string.Concat(degisken," Merhaba!"));

//Compare, CompareTo
//1.değişken 2.değişkene eşitse 0 döndürür.
//1.değişken 2.değişkenden daha büyükse 1 döndürür.
//1.değişken 2.değişkenden küçükse -1 döndürür
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(String.Compare(degisken,degisken2,true)); //Ignorecase: true; duyarsız(büyük küçük harf), false:duyarlı
Console.WriteLine(String.Compare(degisken,degisken2,false)); //Ignorecase: true; duyarsız(büyük küçük harf), false:duyarlı

//Contains
Console.WriteLine(degisken.Contains(degisken3));//degisken içerisinde degisken3 var mı, bulursa true döner
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
Console.WriteLine(degisken.StartsWith("Merhaba"));

//Indexof
Console.WriteLine(degisken.IndexOf("CS"));// arama yaptığında ilk bulduğu yerde C nin indexini verir.
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert
Console.WriteLine(degisken.Insert(0,"Merhaba "));

//PadLeft, PadRight
Console.WriteLine(degisken+degisken3.PadLeft(30));
Console.WriteLine(degisken+degisken3.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50)+degisken3);
Console.WriteLine(degisken.PadRight(50,'-')+degisken3);

//Remove
Console.WriteLine(degisken.Remove(10));//10.indexten başlayarak siler
Console.WriteLine(degisken.Remove(5,3));//5.indexten başlayarak 3 karakter sil
Console.WriteLine(degisken.Remove(0,1));//en baştaki karakteri silmek

//Replace
Console.WriteLine(degisken.Replace("CSharp","C#"));
Console.WriteLine(degisken.Replace(" ","*"));

//Split
Console.WriteLine(degisken.Split(" ")[1]);//boşluğa göre diziye at ve 1.indexi getir.

//Substring
Console.WriteLine(degisken.Substring(4));//4.,ndexten sonuna kadar getir
Console.WriteLine(degisken.Substring(4,6));



