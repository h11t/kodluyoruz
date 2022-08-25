/*Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
*/
using System.Collections;
ArrayList sesliharfler=new ArrayList();
char[] harfler=(Console.ReadLine()).ToCharArray();
foreach (var h in harfler)
{
    if(h=='a' ||h=='e' ||h=='ı' ||h=='i' ||h=='o' ||h=='ö' ||h=='u' ||h=='ü')
    {
        sesliharfler.Add(h);
    }
}
sesliharfler.Sort();
foreach (var item in sesliharfler)
{
    Console.WriteLine(item);
}

