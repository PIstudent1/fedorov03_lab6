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
            Driver drive = new Driver();
            Date date1 = new Date();
            Date date2 = new Date();
            drive.Input();
            drive.Output();
            date1.Init(12,12,2021);
            date2.Init(12,12,1990);
            date1.Indays(date2);
        }
    }
}
