using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorN8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeOneGuest = 10;
            Console.WriteLine("Введите количество человек в очереди");
            int amountGuestInTurn = int.Parse(Console.ReadLine());
            int MinutsInHours = 60;
            int allMinutsInTurn = (timeOneGuest * amountGuestInTurn);
            int minutsWaitTime = allMinutsInTurn % MinutsInHours;
            int hourseWaitTime = allMinutsInTurn / MinutsInHours;
            Console.WriteLine("Осталось ждать - " + hourseWaitTime + " часа " + minutsWaitTime + " минут");
            Console.ReadLine();
        }
    }
}
