using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько бабуль перед тобой?");
        var grandmothers = Convert.ToByte(Console.ReadLine());
        var timeReceipt = 10;
        var hour = 60;
        var timeWaiting = grandmothers * timeReceipt;
        var timeHour = timeWaiting / hour;
        var timeMinuts = timeWaiting % hour;
        Console.WriteLine($"Если не будет всяких (я только спросить), то ждать осталось {timeHour} часов и {timeMinuts} минут");
    }
}