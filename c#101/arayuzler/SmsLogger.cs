public class SmsLogger : ILogger
{
    public void writeLog()
    {
        Console.WriteLine("SMS olarak log yazar");
    }
}