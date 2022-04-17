using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько бабуль перед тобой?");
        byte grandmothers = Convert.ToByte(Console.ReadLine());
        const byte timeReceipt = 10;
        const byte minutsInHour = 60;
        int timeWaiting = grandmothers * timeReceipt;
        int timeWaitingHour = timeWaiting / minutsInHour;
        int timeWaitingMinuts = timeWaiting % minutsInHour;
        Console.WriteLine($"Если не будет всяких (я только спросить), то ждать осталось {timeWaitingHour} часов и {timeWaitingMinuts} минут");
    }
}
