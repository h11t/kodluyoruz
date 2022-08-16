
Console.WriteLine(DateTime.Now);//günün tarihi
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(5));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

//Datetime Format
Console.WriteLine(DateTime.Now.ToString("dd"));//ayın bugün kaçı
Console.WriteLine(DateTime.Now.ToString("ddd")); // gün olarak karşılığını ama kısaltılmışını(3 karakter olarak)
Console.WriteLine(DateTime.Now.ToString("dddd"));//bir üsttekinin tam halini

Console.WriteLine(DateTime.Now.ToString("MM"));// bulunan ayın sayı olarak  karışılığı
Console.WriteLine(DateTime.Now.ToString("MMM"));// ay olarak karşılığını ama kısaltılmışını(3 karakter olarak)
Console.WriteLine(DateTime.Now.ToString("MMMM"));//bir üsttekinin tam halini

Console.WriteLine(DateTime.Now.ToString("yy")); //bulunulan yıl son 2 hanesi
Console.WriteLine(DateTime.Now.ToString("yyy")); //bulunulan yıl tam karşılığı
Console.WriteLine(DateTime.Now.ToString("yyyy")); //bulunulan yıl tam karşılığı


//Math Kütüphanesi
Console.WriteLine(Math.Abs(-25));//25
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3));//22.3 ten büyük en küçük tam sayıyı getirir 23( yukarı yuvarla)
Console.WriteLine(Math.Round(22.3));// 22.3 e en yakın sayıyı 22 yi getirir
Console.WriteLine(Math.Round(22.7));// 22.7 e en yakın sayıyı 23 yi getirir
Console.WriteLine(Math.Round(22.5));// 22.5 e en yakın sayıyı 22 yi getirir
Console.WriteLine(Math.Floor(22.7));//22.7 den küçük en büyük tam sayıyı (aşağıya yuvarlar) 22

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));

Console.WriteLine(Math.Pow(3,4));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Log(9));//9 un e tabanındaki logaritmik karşılığı
Console.WriteLine(Math.Exp(3));// e üzeri 3 verir
Console.WriteLine(Math.Log10(10));
















