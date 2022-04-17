using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько бабуль перед тобой?");
        byte grandmothers = Convert.ToByte(Console.ReadLine());
        const byte timeReceipt = 10;
        const byte hour = 60;
        ushort timeWaiting = grandmothers * timeReceipt;
        ushort timeHour = timeWaiting / hour;
        byte timeMinuts = timeWaiting % hour;
        Console.WriteLine($"Если не будет всяких (я только спросить), то ждать осталось {timeHour} часов и {timeMinuts} минут");
    }
}
