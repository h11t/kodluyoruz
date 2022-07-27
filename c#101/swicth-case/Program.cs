using System;

namespace swicth_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;

            switch (month)
            {
                case 1: System.Console.WriteLine("Ocak ayındasınız");break;
                case 2: System.Console.WriteLine("Şubat ayındasınız");break;
                case 3: System.Console.WriteLine("Mart ayındasınız");break;
                case 4: System.Console.WriteLine("Nisan ayındasınız");break;
                case 5: System.Console.WriteLine("Mayıs ayındasınız");break;
                case 6: System.Console.WriteLine("Haziran ayındasınız");break;
                case 7: System.Console.WriteLine("Temmuz ayındasınız");break;
                case 8: System.Console.WriteLine("Ağustos ayındasınız");break;
                case 9: System.Console.WriteLine("Eylül ayındasınız");break;
                case 10: System.Console.WriteLine("Ekim ayındasınız");break;
                case 11: System.Console.WriteLine("Kasım ayındasınız");break;
                case 12: System.Console.WriteLine("Aralık ayındasınız");break;

                default:
                System.Console.WriteLine("yanlış bir aydasınız");break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                System.Console.WriteLine("kış ayındasınız");break;

                case 3:
                case 4:
                case 5:
                System.Console.WriteLine("ilkbahar ayındasınız");break;

                case 6:
                case 7:
                case 8:
                System.Console.WriteLine("yaz ayındasınız");break;

                case 9:
                case 10:
                case 11:
                System.Console.WriteLine("sonbahar ayındasınız");break;

                default:
                break;
            }
        }
    }
}
