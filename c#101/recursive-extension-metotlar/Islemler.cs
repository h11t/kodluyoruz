
class Islemler
{

    public int Expo(int sayi, int us)
    {   
        if(us<2)
            return sayi;
        return Expo(sayi,us-1)*sayi;
    }

}