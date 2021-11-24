using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ticket
    {
        private int sum;
        private string destination;
        private int hours;
        private int minutes;
        Driver driver = new Driver();


        public int Sum
        {
            get { return sum; }

            set
            {
                if (value < 0)
                    Console.WriteLine("Сумма не может быть отрицательной");
                else
                    sum = value;
            }
        }

        public string Destination
        {
            get { return destination; }

            set
            {
                destination = value;
            }
        }

        public int Hours
        {
            get { return hours; }

            set
            {
                if (value < 0 || value > 24)
                    Console.WriteLine("Часы должны быть в диапазоне от 0 до 24");
                else
                    hours = value;
            }
        }

        public int Minutes
        {
            get { return minutes; }

            set
            {
                if (value < 0 || value > 60)
                    Console.WriteLine("Минуты должны быть в диапазоне от 0 до 60");
                else
                    minutes = value;
            }
        }

        public void Output()
        {
            if (sum <= 0 || String.IsNullOrEmpty(destination) || hours < 0 || minutes < 0)
            {
                Console.WriteLine("Ошибка инициализации данных о билете! Были переданы неверные значения!");
            }
            else {
                Console.WriteLine("\nИнформация о билете:");
                Console.WriteLine($"\nЦена: {sum}");
                Console.WriteLine($"\nПункт назначения: {destination}");
                Console.WriteLine($"\nВремя отправления: {hours}:{minutes}");
                driver.Output();
            }
        }

        public void Init(int sum, string destination, int hours, int minutes, Driver driver)
        {
            if(sum > 0)
            {
                Sum = sum;
            }
            if(!String.IsNullOrEmpty(destination)){
                Destination = destination;
            }
            if(hours >= 0)
            {
                Hours = hours;
            }

            if( minutes >= 0)
            {
                Minutes = minutes;
            }
            this.driver = driver;
        }

        public void Input()
        {
            int sum, hours, minutes;
            string destination;
            Driver driver = new Driver();
            do
            {
                Console.WriteLine("Введите цену билета:");
                while (!int.TryParse(Console.ReadLine(), out sum))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (sum <= 0);
            Sum = sum;
            do
            {
                Console.WriteLine("\nВведите пункт назначения: ");
                destination = Console.ReadLine();
                if (String.IsNullOrEmpty(destination) || String.IsNullOrWhiteSpace(destination))
                {
                    Console.WriteLine("\nВы ничего не ввели! Повторите ввод: ");
                }
            } while (String.IsNullOrEmpty(destination) || String.IsNullOrWhiteSpace(destination));
            Destination = destination;
            do
            {
                Console.WriteLine("Введите часы:");
                while (!int.TryParse(Console.ReadLine(), out hours))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (hours < 0);
            Hours = hours;
            do
            {
                Console.WriteLine("Введите минуты:");
                while (!int.TryParse(Console.ReadLine(), out minutes))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (minutes < 0);
            Minutes = minutes;
            driver.Input();
            this.driver = driver;
        }

        public void Sale(out int discount)
        {
            discount = 30;
            int sl1 = discount;
            discount = sum - (sum * sl1 / 100);
            Console.WriteLine($"\n\nЦена с учетом скидки {sl1} процент(ов): {discount}");
            Console.ReadLine();
        }
    }
}
