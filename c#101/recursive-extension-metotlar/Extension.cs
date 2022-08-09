static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    } 

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi=param.Split(" "); // bu stringi boşluklarına göre ayır ve diziye al.
        return string.Join("*",dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] sortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }
    public static bool IsEvenNumber(this int param)
    {
        return param%2==0;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }
}
