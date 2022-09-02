
class DeleteNumber:ContactClass
{
    public void Delete()
    {
        
        string choice="2";
        while(choice=="2")
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string nameSurname=Console.ReadLine();
            int count=0;
        foreach (var item in contact)
        {
            if(item.Value.Contains(nameSurname))
            {
                contact.Remove(item.Key);
                Console.WriteLine($"{item.Value} başarıyla silindi.");
                choice="1";
                break;
            }
            else
            {
                count++;
                continue;
            }
        }

        if(count==contact.Count)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");

            choice=Console.ReadLine();
            if(choice=="1")
            {
                Console.WriteLine("Çıkış yapıldı.");
            }
        }
        }
    }
}