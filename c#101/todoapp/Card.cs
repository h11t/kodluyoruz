
class Card 
{
    private string baslik;
    private string icerik;
    private string atananKisi;
    private string buyukluk;

    public Card(string baslik, string ıcerik, string atananKisi, string buyukluk)
    {
        Baslik = baslik;
        Icerik = ıcerik;
        AtananKisi = atananKisi;
        Buyukluk = buyukluk;
    }

    public string Baslik { get => baslik; set => baslik = value; }
    public string Icerik { get => icerik; set => icerik = value; }
    public string AtananKisi { get => atananKisi; set => atananKisi = value; }
    public string Buyukluk { get => buyukluk; set => buyukluk = value; }

}