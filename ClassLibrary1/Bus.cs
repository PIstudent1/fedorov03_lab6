using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bus
    {
        private int number;
        private string mark;
        private Engine engine = new Engine();


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

        public string Mark
        {
            get { return mark; }

            set { mark = value; }
        }

        public void Output()
        {
            if (number <= 0 || String.IsNullOrEmpty(mark))
            {
                Console.WriteLine("Ошибка инициализации данных об автобусе! Были переданы неверные значения!");
            }
            else
            {
                Console.WriteLine("\nИнформация об автобусе:");
                Console.WriteLine($"\nНомер автобуса: {number}");
                Console.WriteLine($"\nМарка: {mark}");
                engine.Output();
            }
        }

        public Bus() {} //Конструктор без параметров

        public Bus(int value) //Конструктор с одним параметром
        {
            number = value;
        }

        public Bus(int number, string mark, Engine engine) //Конструктор с параметрами
        {
            if(number > 0)
            {
                Number = number;
            }
            if (!String.IsNullOrEmpty(mark))
            {
               Mark = mark;
            }
            this.engine = engine;
        }

        public void Input()
        {
            int number;
            string mark;
            Engine engine = new Engine();

            do
            {
                Console.WriteLine("Введите номер автобуса:");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
            } while (number <= 0 );
            Number = number;
            do
            {
                Console.WriteLine("\nВведите марку: ");
                mark = Console.ReadLine();
                if (String.IsNullOrEmpty(mark) || String.IsNullOrWhiteSpace(mark))
                {
                    Console.WriteLine("\nВы ничего не ввели! Повторите ввод! ");
                }
            } while (String.IsNullOrEmpty(mark) || String.IsNullOrWhiteSpace(mark));
            Mark = mark;
            engine.Input();
            this.engine = engine;
        }
    }
}
