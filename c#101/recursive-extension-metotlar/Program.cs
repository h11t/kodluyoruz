// See https://aka.ms/new-console-template for more information

//Rekürsif - Öz yinelemeli 
//3^4

int result=1;
for (int i = 1; i < 5; i++)
{
    result=result*3;
}
Console.WriteLine(result);

Islemler instance= new();
Console.WriteLine(instance.Expo(3,4));

//Extension Metotlar
string ifade="Hilal Tekdemir";
bool sonuc=ifade.CheckSpaces();
Console.WriteLine(sonuc);
if(sonuc)
{
    Console.WriteLine(ifade.RemoveWhiteSpaces());
}

Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi={9,3,6,2,1,5,0};
dizi.sortArray();
dizi.EkranaYazdir();

int sayi=5;
Console.WriteLine(sayi.IsEvenNumber());

Console.WriteLine(ifade.GetFirstCharacter());



