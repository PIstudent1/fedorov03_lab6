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
                this.name = "-";
            }
            else
            {
                this.name = name;
            }
            if (String.IsNullOrEmpty(lastname))
            {
                this.lastname = "-";
            }
            else
            {
                this.lastname = lastname; 
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
            this.name = name;
            do
            {
                Console.WriteLine("\nВведите фамилию: ");
                lastname = Console.ReadLine();
                if (String.IsNullOrEmpty(lastname) || String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("\nВы ничего не ввели! Повторите ввод! ");
                }
            } while (String.IsNullOrEmpty(lastname) || String.IsNullOrWhiteSpace(lastname));
            this.lastname = lastname;
            Console.WriteLine("\nВведите дату рождения: ");
            birthdate.Input();
            this.birthdate = birthdate;
        }
    }
}
