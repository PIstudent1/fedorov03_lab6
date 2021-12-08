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
            ////Driver drive = new Driver();
            //Date[] date = new Date[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    date[i] = new Date();
            //    date[i].Input();
            //}
            //++date[0];
            //date[0].Output();
            //date[0].Indays(date[1]);
            //Date date1 = new Date();
            //date1 = date[0] + date[1];
            //date1.Output();
            Ticket tick = new Ticket();
            int discount;
            tick.Input();
            tick.Sale(out discount);
            Console.WriteLine($"\n\nЦена с учетом скидки: {discount}");
            Console.ReadLine();
        }
    }
}
