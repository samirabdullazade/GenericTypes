using System;
using System.Collections.Generic;

namespace GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomCollection collection = new CustomCollection();

            string choice;
            do
            {
                Console.WriteLine("1) Employee Əlavə Etmək");
                Console.WriteLine("2) İd-ə görə Employee-ni tapmaq");
                Console.WriteLine("3) Bütün Employeeləri Ekrana çıxarmaq");
                Console.Write("Seçiminizi edin (1/2/3): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Ad: ");
                        string name = Console.ReadLine();
                        Console.Write("Soyad: ");
                        string surname = Console.ReadLine();
                        Console.Write("Yaş: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Maaş: ");
                        decimal salary = Convert.ToDecimal(Console.ReadLine());

                        collection.Add(new Employee(name, surname, age, salary));
                        break;

                    case "2":
                        Console.Write("İd: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Person person = collection.GetById(id);
                        if (person != null)
                        {
                            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Surname: {person.Surname}, Age: {person.Age}");
                        }
                        else
                        {
                            Console.WriteLine("İstifadəçi tapılmadı");
                        }
                        break;

                    case "3":
                        collection.PrintAll();
                        break;

                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }

                Console.Write("Davam etmək istəyirsiniz? (yes/no): ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "yes");
        }
            class CustomCollection
        {
            private List<Person> _persons = new List<Person>();

            public void Add(Person person)
            {
                _persons.Add(person);
            }

            public Person GetById(int id)
            {
                foreach (var person in _persons)
                {
                    if (person.Id == id)
                    {
                        return person;
                    }
                }
                return null;
            }
            public void PrintAll()
            {
                foreach (var person in _persons) ;
            }
        }
    }
}
