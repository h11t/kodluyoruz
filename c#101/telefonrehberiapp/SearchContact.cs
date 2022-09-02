
public class SearchContact:ContactClass
{
    public void Search()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine();
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        string choice=Console.ReadLine();
        if(choice=="1")
        {
            Console.WriteLine("Lütfen aramak istediğiniz kişinin isim veya soyismini giriniz:");
            string nameSurname=Console.ReadLine();
            foreach (var item in contact)
            {
                if(item.Value.Contains(nameSurname))
                {
                    Console.WriteLine($"İsim-Soyisim:{item.Value}");
                    Console.WriteLine($"Telefon Numarası:{item.Key}");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        else if(choice=="2")
        {
            Console.WriteLine("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz:");
            string telNum=Console.ReadLine();
            foreach (var item in contact)
            {
                if(item.Key.Contains(telNum))
                {
                    Console.WriteLine($"İsim-Soyisim:{item.Value}");
                    Console.WriteLine($"Telefon Numarası:{item.Key}");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}