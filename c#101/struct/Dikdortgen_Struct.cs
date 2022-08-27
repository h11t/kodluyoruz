
struct Dikdortgen_Struct
{
    public int kisaKenar;
    public int uzunKenar;
    public Dikdortgen_Struct(int kisaKenar, int uzunKenar)// structlarda parametresiz constructor tanımlanamaz
    {
        this.kisaKenar = kisaKenar;
        this.uzunKenar = uzunKenar;
    }
    public long AlanHesapla()
    {
        return this.kisaKenar*this.uzunKenar;
    }
}
