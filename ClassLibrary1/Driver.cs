using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Driver
    {
        private string name;
        private string lastname;
        private Date birthdate = new Date();

        public string Name { get; set; }

        public string Lastname { get; set; }

        public Driver() { 
        }

        public void Output()
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastname))
            {
                Console.WriteLine("Ошибка инициализации данных о водителе! Были переданы неверные значения!");
            }
            else
            {
                Console.WriteLine("\nИнформация о водителе:");
                Console.WriteLine($"\nИмя: {name}");
                Console.WriteLine($"\nФамилия: {lastname}");
                Console.WriteLine("\nДата рождения:");
                birthdate.Output();
            }
        }

        public void Init(string name, string lastname, Date birthdate)
        {
            if (String.IsNullOrEmpty(name))
            {
                Name = "-";
            }
            else
            {
                Name = name;
            }
            if (String.IsNullOrEmpty(lastname))
            {
                Lastname = "-";
            }
            else
            {
                Lastname = lastname; 
            }
            this.birthdate = birthdate;
        }

        public void Input()
        {
            string name;
            string lastname;
            Date birthdate = new Date();
            Console.WriteLine("\nВведите информацию о водителе:");
            do {
                Console.WriteLine("\nВведите имя: ");
                name = Console.ReadLine();
                if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("\nВы ничего не ввели! Повторите ввод: ");
                }
            } while (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) ;
            Name = name;
            do
            {
                Console.WriteLine("\nВведите фамилию: ");
                lastname = Console.ReadLine();
                if (String.IsNullOrEmpty(lastname) || String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("\nВы ничего не ввели! Повторите ввод! ");
                }
            } while (String.IsNullOrEmpty(lastname) || String.IsNullOrWhiteSpace(lastname));
            Lastname = lastname;
            Console.WriteLine("\nВведите дату рождения: ");
            birthdate.Input();
            this.birthdate = birthdate;
        }
    }
}
