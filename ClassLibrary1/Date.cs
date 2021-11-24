using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Date
    {
        private int day;
        private int month;
        private int year;


        public int Day
        {
            get { return day; }

            set
            {
                if (value < 1 || value > 31)
                    Console.WriteLine("Дата должна быть в диапазоне от 1 до 31");
                else
                    day = value;
            }
        }

        public int Month
        {
            get { return month; }

            set
            {
                if (value < 1 || value > 12)
                    Console.WriteLine("Месяц должен быть в диапазоне от 1 до 12");
                else
                    month = value;
            }
        }

        public int Year
        {
            get { return year; }

            set
            {
                if (value < 1)
                    Console.WriteLine("Год должен быть в положительным");
                else
                    year = value;
            }
        }

        public Date()
        {
        }

        public void Output()
        {
            if (day == 0 || month == 0 || year == 0)
            {
                Console.WriteLine("Ошибка инициализации даты! Были переданы неверные значения!");
            }
            else
            {
                Console.WriteLine($"{day}.{month}.{year}");
            }
            Console.ReadLine();
        }

        public void Init(int day, int month, int year)
        {
            if (day <= 0 || day > 31)
            {
                this.day = 0;
            }
            else
            {
                Day = day;
            }
            if (month <= 0 || month > 12)
            {
                this.month = 0;
            }
            else
            {
                Month = month;
            }
            if (year <= 0)
            {
                this.year = 0;
            }
            else
            {
                Year = year;
            }
        }

        public void Input()
        {
            int day, month, year;
            do
            {
                Console.WriteLine("Введите день:");
                while (!int.TryParse(Console.ReadLine(), out day))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (day <= 0 || day > 31);
            Day = day;
            do
            {
                Console.WriteLine("Введите месяц:");
                while (!int.TryParse(Console.ReadLine(), out month))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (month <= 0 || month > 12);
            Month = month;

            do
            {
                Console.WriteLine("Введите год:");
                while (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (year <= 0);
            Year = year;
        }
        public void Indays(Date date1)
        {
            int sum, sum1;
            if (month < 3)
            {
                year--; month += 12;
            }
            sum = 365 * year + year / 4 - year / 100 + year / 400 + (153 * month - 457) / 5 + day - 306;
            if (date1.month < 3)
            {
                date1.year--; date1.month += 12;
            }
            sum1 = 365 * date1.year + date1.year / 4 - date1.year / 100 + date1.year / 400 + (153 * date1.month - 457) / 5 + date1.day - 306;
            if (sum < sum1)
            {
                Console.WriteLine("Ошибка. Вторая дата больше первой.");
            }
            else
            {
                Console.WriteLine($"Количество дней между датами: {sum - sum1}");
            }
            Console.ReadLine();
        }


        public static Date operator+(Date date, Date date1)
        {
            return new Date { Day = date.day + date1.day, Month = date.month, Year = date.year };
        }
    }
}
