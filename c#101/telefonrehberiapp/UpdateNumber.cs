
public class UpdateNumber:ContactClass
{
    public void Update()
    {
        string choice="2";
        while(choice=="2")
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string name = Console.ReadLine();
            int count = 0;
            foreach (var item in contact)
            {
                if(item.Value.Contains(item.Value))
                {
                    Console.WriteLine("Lütfen yeni numarasını giriniz:");
                    string number=Console.ReadLine();
                    string newname=item.Value;
                    contact.Remove(item.Key);
                    contact.Add(number,newname);
                    break;
                }
                else
                {
                    continue;
                }
            }
            if(count==contact.Count)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                choice=Console.ReadLine();
                if(choice=="1")
                {
                    Console.WriteLine("Çıkış yapıldı");
                }
            }

            foreach (var item in contact)
            {
                Console.WriteLine(item);
            }
        }        
    }
}