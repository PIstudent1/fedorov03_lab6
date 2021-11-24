using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fedorov03_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = 20;
            Ticket tick = new Ticket();
            tick.Input();
            tick.Sale(ref discount);
            Console.WriteLine($"\n\nЦена с учетом скидки  процент(ов): {discount}");
            Console.ReadLine();
        }
    }
}
