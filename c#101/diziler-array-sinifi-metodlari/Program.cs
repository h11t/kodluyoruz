// See https://aka.ms/new-console-template for more information

//sort
int[] sayiDizisi={23,12,4,86,72,3,11,17};
System.Console.WriteLine("*****sırasız liste");
foreach (var item in sayiDizisi)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("*****sıralı liste");
Array.Sort(sayiDizisi);
foreach (var item in sayiDizisi)
{
    System.Console.WriteLine(item);
}

//CLEAR: Verilen dizide, verilen indexten başlayarak şu kadar elemanı sıfırlar
System.Console.WriteLine("*****Array Clear");
Array.Clear(sayiDizisi,2,2);
foreach (var item in sayiDizisi)
{
    System.Console.WriteLine(item);
}


//REVERSE:Tersine çevirir.
System.Console.WriteLine("*****Array Reverse");
Array.Reverse(sayiDizisi);
foreach (var item in sayiDizisi)
{
    System.Console.WriteLine(item);
}


//INDEXOF: verilen dizide verilen elemanının indexini döner
System.Console.WriteLine("*****Array IndexOf");
System.Console.WriteLine(Array.IndexOf(sayiDizisi,23));

//RESIZE: yeniden boyutlandırma
System.Console.WriteLine("*****Array Resize");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8]=99;
foreach (var item in sayiDizisi)
{
    System.Console.WriteLine(item);
}




