
class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi;  }
    

    private string Isim;
    private string Soyisim;
    private string Departman;
    public Calisan(string isim, string soyisim, string departman)
    {
        Isim = isim;
        Soyisim = soyisim;
        Departman = departman;
        calisanSayisi++;
    }
    static Calisan()
    {
        calisanSayisi=0;        
    }
}