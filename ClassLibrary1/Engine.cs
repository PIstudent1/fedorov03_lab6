using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Engine : System.ICloneable
    {
        private int number;
        private int power;
        private Date createdate { get; set; }


        public int Number
        {
            get { return number; }

            set
            {
                if (value < 1 || value > 999)
                    Console.WriteLine("Номер должен быть в диапазоне от 1 до 999");
                else
                    number = value;
            }
        }

        public int Power
        {
            get { return power; }

            set
            {
                if (value < 1 )
                    Console.WriteLine("Мощность не может быть отрицательной или равна 0");
                else
                    power = value;
            }
        }
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
        public Engine() {} //Конструктор без параметров

        public Engine(int value) //Конструктор с одним параметром 
        {
            number = value;
        }
        public Engine(int number, int power, Date createdate) //Конструктор с параметрами
        {
            if (number > 0)
            {
                Number = number;
            }
            if(power > 0)
            {
                Power = power;
            }
            this.createdate = createdate;
        }

        public object Clone()  //Глубокое копирование
        {
            Date date = new Date { Day = createdate.Day, Month = createdate.Month, Year = createdate.Year };
            return new Engine
            {
                Number = Number,
                Power = Power,
                createdate = date
            };
        
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
            Number = number;
            do
            {
                Console.WriteLine("Введите мощность(в л.с.):");
                while (!int.TryParse(Console.ReadLine(), out power))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (power <= 0);
            Power = power;
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
