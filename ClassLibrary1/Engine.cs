using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Engine
    {
        private int number;
        private int power;
        private Date createdate;

        public void Output()
        {
            if (number <= 0 || power <= 0)
            {
                Console.WriteLine("Ошибка инициализации данных о двигателе! Были переданы неверные значения!");
            }
            else
            {
                Console.WriteLine("\nИнформация о двигателе:");
                Console.WriteLine($"\nСерийный номер: {number}");
                Console.WriteLine($"\nМощность: {power} л.с.");
                Console.WriteLine("\nДата производства:");
                createdate.Output();
            }
        }
        public Engine() { }
        public void Init(int number, int power, Date createdate)
        {
            if (number > 0)
            {
                this.number = number;
            }
            if(power > 0)
            {
                this.power = power;
            }
            this.createdate = createdate;
        }

        public void Input()
        {
            int number, power;
            Date createdate = new Date();
            do
            {
                Console.WriteLine("Введите серийный номер:");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (number <= 0);
            this.number = number;
            do
            {
                Console.WriteLine("Введите мощность(в л.с.):");
                while (!int.TryParse(Console.ReadLine(), out power))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (power <= 0);
            this.power = power;
            Console.WriteLine("\nВведите дату производства: ");
            createdate.Input();
            this.createdate = createdate;
        }

        public void Tokvt()
        {
            double ls = 0.736, res = 0;
            res = power * ls;
            Console.WriteLine($"\nМощность двигалеля в кВт: {Math.Round(res,2)}");
        }
    }
}
