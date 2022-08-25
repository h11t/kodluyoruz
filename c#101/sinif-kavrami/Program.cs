
//erişim belirleyiciler
//public ->heryerden erişim
//private ->tanımlandığı sınıf içerisinden
//internal ->tanımlandığı proje içerisinden
//protected ->tanımlandığı sınıfta ya da o sınıftan miras alınan sınıflarda kullanılır

Calisan calisan1=new Calisan();
calisan1.Ad="Ayşe";
calisan1.Soyad="Kara";
calisan1.No=23232333;
calisan1.Departman="İnsan kaynakları";
calisan1.CalisanBilgileri();

Calisan calisan2=new Calisan();
calisan2.Ad="Yeliz";
calisan2.Soyad="Kaya";
calisan2.No=124515;
calisan2.Departman="Satın Alma";
calisan2.CalisanBilgileri();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public void CalisanBilgileri()
    {
        Console.WriteLine($"Çalışan adı:{Ad}");
        Console.WriteLine($"Çalışan soyadı:{Soyad}");
        Console.WriteLine($"Çalışan numarası:{No}");
        Console.WriteLine($"Çalışan departmanı:{Departman}");
    }
}