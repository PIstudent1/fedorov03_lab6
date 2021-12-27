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
            //Date[,] date2 = new Date[3,2];
            //Date[] date1 = new Date[2];

            //for (int i = 0; i < 1; i++)
            //{
            //    date1[i] = new Date(12,11,2021);
            //    date1[i].Output();
            //}

            //for(int i =0; i < 3; i++)
            //{
            //    for(int j =0; j < 2; j++)
            //    {
            //        date2[i, j] = new Date(12+i, 11, 2021);
            //        date2[i, j].Output();
            //        Console.Write("  ");
            //    }

            //}

            Human human = new Human();
            human.Input();
            human.ToString();
        }
    }
}
