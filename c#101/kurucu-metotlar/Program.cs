

Calisan calisan1=new Calisan("Ayşe","Kara",23232333,"İnsan kaynakları");
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
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;
    }
    public Calisan(){}
    
    public void CalisanBilgileri()
    {
        Console.WriteLine($"Çalışan adı:{Ad}");
        Console.WriteLine($"Çalışan soyadı:{Soyad}");
        Console.WriteLine($"Çalışan numarası:{No}");
        Console.WriteLine($"Çalışan departmanı:{Departman}");
    }
}