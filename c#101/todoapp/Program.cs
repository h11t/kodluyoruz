
 while (true)
{
    string secim = Board.secim();
    if (secim == "1")
    {
         Board.Listele();
    }
    else if (secim == "2")
    {
        Card newCard = Board.kartOlustur();
        Board.kartEkle(newCard);
    }
    else if (secim == "3")
    {
        Card newCard = Board.kartOlustur();
        Board.kartGuncelle(newCard);
    }
    else if (secim == "4")
    {
        Board.kartSil();
    }
    else if (secim == "5")
    {
        Board.kartTaşı();
    }
    else if (secim == "6")
    {
        break;
    }
    else
    {
        Console.WriteLine("Hatalı giriş yaptınız.");
    }
}