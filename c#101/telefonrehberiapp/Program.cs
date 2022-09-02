
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
Console.WriteLine("**********************************");
Console.WriteLine("(1) Yeni Numara Kaydetmek");
Console.WriteLine("(2) Varolan Numarayı Silmek");
Console.WriteLine("(3) Varolan Numarayı Güncelleme");
Console.WriteLine("(4) Rehberi Listelemek");
Console.WriteLine("(5) Rehberde Arama Yapmak");

string choice=Console.ReadLine();
switch (choice)
{
    case "1":
        NewNumber newnum=new NewNumber();
        newnum.Add();
        newnum.ListContact();
        break;
    case "2":
        DeleteNumber deletenum=new DeleteNumber();
        deletenum.Delete();
        break;
    case "3":
        UpdateNumber updateNum=new UpdateNumber();
        updateNum.Update();
        break;
    case "4":
        ContactClass contactClass=new ContactClass();
        contactClass.ListContact();
        break;
    case "5":
        SearchContact searchContact=new SearchContact();
        searchContact.Search();
        break;    
}
Console.ReadLine();