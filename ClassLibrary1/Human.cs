using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Human
    {
        private string name;
        private string lastname;
        private Date birthdate = new Date();

        public string Name { get; set; }

        public string Lastname { get; set; }

        public Human() {  //Конструктор без параметров
        }

        public override string ToString()
        {
            return Name + " " + Lastname + " " + birthdate;
        }

        public Human(string value) //Конструктор с одним параметром
        {
            name = value;
        }

        public Human(string name, string lastname, Date birthdate) //Конструктор с параметрами
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

    class Driver : Human
    {
        private Bus driversbus;

        public void Inputdriver()
        {
            Console.WriteLine("\nВведите информацию о водителе:");
            Input();
            Console.WriteLine("\nВведите информацию об автобусе: ");
            driversbus.Input();
        }

        public void Outputdriver()
        {
            Console.WriteLine("\nИнформация о водителе:");
            ToString();
            Console.WriteLine("\nИнформация об автобусе: ");
            driversbus.Output();
        }

        public Driver(string name, string lastname, Date birthdate, Bus driversbus) : base(name, lastname, birthdate)
        {
            this.driversbus = driversbus;
        }

    }

    public class Passenger : Human
    {

    }
}


