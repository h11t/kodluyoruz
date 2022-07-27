// See https://aka.ms/new-console-template for more information
using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time>=6 && time<11)
            System.Console.WriteLine("günaydın");
            else if(time<=18)
            System.Console.WriteLine("İyi günler");
            else
             System.Console.WriteLine("İyi geceler");

            string sonuc=time<=18 ? "İyi günler": "İyi geceler";
            System.Console.WriteLine(sonuc);

            sonuc=time>=6 && time<11 ? "Günaydın": time<=18 ? "İyi günler" : "İyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
