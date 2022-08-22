using System.Collections;


ArrayList liste=new();
liste.Add("Ayşe");
liste.Add(2);
liste.Add(true);
liste.Add('A');

Console.WriteLine(liste[1]);
foreach (var item in liste)
{
    System.Console.WriteLine(item);
}

//AddRange:birden fazla elemanı toplu halde eklemek
System.Console.WriteLine("********AddRange*************");
string[] renkler={"Kırmızı","Sarı","Yeşil"};
List<int> sayilar=new List<int>(){1,8,3,7,9,92,5};
liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach (var item in liste)
{
    System.Console.WriteLine(item);
}

//Sort
System.Console.WriteLine("********sort ******");
//liste.Sort(); compile sırasında değil ancak runtimeda hata alır. içerisinde bool string vs var


//Binary Search
System.Console.WriteLine("********BinarySearch");
//System.Console.WriteLine(liste.BinarySearch(9);
//binaryserach kullanılmadan önce sort işlemi yapıalrak kendi içerisinde sıralanmalı

//Reverse: Ortasından aynalar
System.Console.WriteLine("******Reverse"); 
//liste.Reverse();