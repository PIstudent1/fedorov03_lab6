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

        public Bus() { }

        public void Init(int number, string mark, Engine engine)
        {
            if(number > 0)
            {
                this.number = number;
            }
            if (!String.IsNullOrEmpty(mark))
            {
                this.mark = mark;
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
            this.number = number;
            do
            {
                Console.WriteLine("\nВведите марку: ");
                mark = Console.ReadLine();
                if (String.IsNullOrEmpty(mark) || String.IsNullOrWhiteSpace(mark))
                {
                    Console.WriteLine("\nВы ничего не ввели! Повторите ввод! ");
                }
            } while (String.IsNullOrEmpty(mark) || String.IsNullOrWhiteSpace(mark));
            this.mark = mark;
            engine.Input();
            this.engine = engine;
        }
    }
}
