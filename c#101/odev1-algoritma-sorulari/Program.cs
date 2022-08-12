//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


int sayi1=PozitifSayiAl(); 
Console.WriteLine("Girdiğiniz sayı;{0}",sayi1);

int PozitifSayiAl()
{
    int sayi1;
    do
    {
        Console.WriteLine("Merhaba, pozitif bir sayı girişi yapar mısınız?");
        sayi1=Convert.ToInt32(Console.ReadLine());
    } while (sayi1<=0);  
    return sayi1;
}
Console.WriteLine("**********");

Console.WriteLine("Kaç tane pozitif sayı girmek istiyorsunuz");
int n=Convert.ToInt32(Console.ReadLine());
int sayi2=0;
int[] dizi=new int[n];
for(int i=0;i<n;i++)
{
    sayi2=PozitifSayiAl();
    dizi[i]=sayi2;
}
Console.WriteLine("Çift olanlar yazdırılacak");
for (int i = 0; i < n; i++)
{
    if(dizi[i]%2==0)
    Console.WriteLine(dizi[i]);
}
    
//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Console.WriteLine("Pozitif iki sayı girer misiniz?");
int nPozitif=PozitifSayiAl();
int mPozitif=PozitifSayiAl();
Console.WriteLine("{0} adet pozitif sayı girer misiniz?",nPozitif);
int[] dizi1=new int[nPozitif];
int sayi3;
for(int i=0;i<nPozitif;i++)
{
    sayi3=PozitifSayiAl();
    dizi1[i]=sayi3;
}
for (int i = 0; i < nPozitif; i++)
{
    if (dizi1[i]%mPozitif==0 || dizi1[i]==mPozitif)
    {
        Console.WriteLine("{0} Tam bölünür veya eşittir {1} e",dizi1[i],mPozitif);
    }
}

Console.WriteLine("*********");

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
Console.WriteLine("Pozitif bir sayı girer misiniz?");
int sayi4=PozitifSayiAl(); 
string[] dizi2=new string[sayi4];
for (int i = 0; i < sayi4; i++)
{
    Console.WriteLine("Bir kelime yazın");
    dizi2[i]=Console.ReadLine();
}
Array.Reverse(dizi2);
Console.WriteLine("Tersten yazdırılacak");
for (int i = 0; i <sayi4; i++)
{
    Console.WriteLine("{0}",dizi2[i]);
}


//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
Console.WriteLine("Bir cümle yazar mısınız?");
string cumle=Console.ReadLine();
string[] kelimeler=cumle.Split(" ");
int kelimeSayisi=kelimeler.Count();
int harfSayisi=0;
for (int i = 0; i < kelimeSayisi; i++)
{
    harfSayisi+=kelimeler[i].Length;
}
Console.WriteLine("Toplam {0} kadar kelime var",kelimeSayisi);
Console.WriteLine("Toplam {0} kadar harf var",harfSayisi);





    
    





