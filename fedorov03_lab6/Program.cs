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
            //Driver drive = new Driver();
            //Date[] date = new Date[2];
            //for(int i = 0; i < 2; i++)
            //{
            //    date[i] = new Date();
            //    date[i].Input();
            //}
            //date[0].Indays(date[1]);
            Ticket tick = new Ticket();
            int discount;
            tick.Input();
            tick.Sale(out discount);
        }
    }
}
