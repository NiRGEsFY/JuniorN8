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
            int howMuchGuest = int.Parse(Console.ReadLine());
            int minuts = (timeOneGuest * howMuchGuest) % 60;
            int hourse = (timeOneGuest * howMuchGuest) / 60;
            Console.WriteLine("Осталось ждать - " + hourse + " часа " + minuts + " минут");
            Console.ReadLine();
        }
    }
}
