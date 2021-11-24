using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Ticket
    {
        private int sum;
        private string destination;
        private int hours;
        private int minutes;
        Driver driver = new Driver();

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
                this.sum = sum;
            }
            if(!String.IsNullOrEmpty(destination)){
                this.destination = destination;
            }
            if(hours >= 0)
            {
                this.hours = hours;
            }

            if( minutes >= 0)
            {
                this.minutes = minutes;
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
            this.sum = sum;
            do
            {
                Console.WriteLine("\nВведите имя: ");
                destination = Console.ReadLine();
                if (String.IsNullOrEmpty(destination) || String.IsNullOrWhiteSpace(destination))
                {
                    Console.WriteLine("\nВы ничего не ввели! Повторите ввод: ");
                }
            } while (String.IsNullOrEmpty(destination) || String.IsNullOrWhiteSpace(destination));
            this.destination = destination;
            do
            {
                Console.WriteLine("Введите часы:");
                while (!int.TryParse(Console.ReadLine(), out hours))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (hours < 0);
            this.hours = hours;
            do
            {
                Console.WriteLine("Введите минуты:");
                while (!int.TryParse(Console.ReadLine(), out minutes))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (minutes < 0);
            this.minutes = minutes;
            driver.Input();
            this.driver = driver;
        }

        public void Sale()
        {
            int sl1 = 0;
            double sl2 = 0;
            do
            {
                Console.WriteLine("Введите процент скидки:");
                while (!int.TryParse(Console.ReadLine(), out sl1))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (sl1 <= 0);
            sl2 = sum - (sum * sl1 / 100);
            Console.WriteLine($"\n\nЦена с учетом скидки {sl1} процент(ов): {Math.Round(sl2,2)}");
        }
    }
}
