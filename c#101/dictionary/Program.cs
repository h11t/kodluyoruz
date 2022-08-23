

//dictyionary
//using system.collection.generic

Dictionary<int,string> kullanıcılar=new Dictionary<int, string>();
kullanıcılar.Add(10,"Ayşe Yılmaz");
kullanıcılar.Add(12,"Ahmet Yılmaz");
kullanıcılar.Add(18,"Deniz Arda");
kullanıcılar.Add(20,"Özcan Coşar");

//Dizinin elemanlarına erişim
Console.WriteLine("*******Elemanlara erişim*******");
Console.WriteLine(kullanıcılar[12]);
foreach (var item in kullanıcılar)
{
    Console.WriteLine(item.Key+" "+item.Value);
}

//Count
Console.WriteLine("************Count********");
Console.WriteLine(kullanıcılar.Count);

//contains
Console.WriteLine("************Contains********");
Console.WriteLine(kullanıcılar.ContainsKey(12));
Console.WriteLine(kullanıcılar.ContainsValue("Zikri"));

//Remove
Console.WriteLine("************Remove********");
kullanıcılar.Remove(12);
foreach (var item in kullanıcılar)
{
    Console.WriteLine(item.Key+" "+item.Value);
}


//keys
//values
foreach (var item in kullanıcılar.Keys)
{
    Console.WriteLine(item);
}
foreach (var item in kullanıcılar.Values)
{
    Console.WriteLine(item);
}
