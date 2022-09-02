
public class ContactClass
{
    public Dictionary<string,string> contact=new Dictionary<string, string>();
    public ContactClass()
    {
        contact.Add("02121112233","Burhan Altıntop");
        contact.Add("02121112234","Şahika Koçaraslanlı");
        contact.Add("02121112235","İhsan Yıldırım");
        contact.Add("02121112236","Pembe Erdağı");
        contact.Add("02121112237","Şevkat Yerimdar");   
    }

    public void ListContact()
    {
        foreach (var item in contact)
        {
            Console.WriteLine(item);
        }
    }
}