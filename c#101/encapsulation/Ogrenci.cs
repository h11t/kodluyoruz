

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { 
        get => sinif; 
        set => sinif = value <=1 ?  1 : value; 
    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci()
    {
        
    }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("**********Öğrenci Bilgileri**********");
        Console.WriteLine($"Öğrenci adı: {Isim}");
        Console.WriteLine($"Öğrenci soyadı: {Soyisim}");
        Console.WriteLine($"Öğrenci numarası: {OgrenciNo}");
        Console.WriteLine($"Öğrenci sınıfı: {Sinif}");
    }

    public void SinifAtlat()
    {
        Sinif=Sinif+1;
    }
    public void SinifDusur()
    {
        Sinif=Sinif-1;
    }
}