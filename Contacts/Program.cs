using System;

namespace Contacts
{
    internal class Program
    {
        public class ContactBook
        {
            public Name FIO_Name;
            public string PhoneNumber;
            public Adress HomeAdress;
            public Adress WorkAdress;

            public ContactBook(Name name, string PhoneNumber, Adress HomeAdress, Adress WorkAdress)
            {
                this.FIO_Name = name;
                this.PhoneNumber = PhoneNumber;
                this.HomeAdress = HomeAdress;
                this.WorkAdress = WorkAdress;
            }
        }

        public struct Name
        {
            public string? LastName;
            public string? FirstName;
            public string? Surname;

            public string GetFullName()
            {
                return (LastName + " " + FirstName + " " + Surname);
            }
        }

        public struct Adress
        {
            public int? Index;
            public string? Country;
            public string? City;
            public string? Street;
            public string? NumberHome;
            public int Apartment;

            public string? GetAdress()
            {if (Index == 0 && Apartment == 0)
                { return Country + " " + City + " " + Street + " " + NumberHome; }
            else if (Index == 0) 
                { return Country + " " + City + " " + Street + " " + NumberHome + " " + Apartment; }
            else if (Apartment == 0) { return Index + Country + " " + City + " " + Street + " " + " " + NumberHome;}
            else { return Index + " " + Country + " " + City + " " + Street + " " + NumberHome + " " + Apartment; }
            }
        }
        static Adress SetAdress()
        {
            Adress adress = new Adress();
            while (true)
            {
                Console.Write("Индекс: ");
                string Input = Console.ReadLine();
                if (int.TryParse(Input, out int index) || string.IsNullOrEmpty(Input))
                {
                    adress.Index = index;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите корректное значение для индекса.");
                }
            }

            Console.Write("Страна: ");
            adress.Country = Console.ReadLine();

            Console.Write("Город: ");
            adress.City = Console.ReadLine();

            Console.Write("Улица: ");
            adress.Street = Console.ReadLine();

            Console.Write("Дом: ");
            adress.NumberHome = Console.ReadLine();

            while (true)
            {
                Console.Write("Квартира/Офис: ");
                string Input = Console.ReadLine();
                if (int.TryParse(Input, out int index) || string.IsNullOrEmpty(Input))
                {
                    adress.Index = index;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите корректное значение для Квартиры/Офиса.");
                }
            }
            return adress;
        }

        static void Main(string[] args)
        {
            ContactBook[] contacts = new ContactBook[2];

            for (int i = 0; i < contacts.Length; i++)
            {
                try
                {

                    Console.WriteLine("Введите данные для контакта " + (i + 1));
                    Console.Write("Фамилия: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Имя: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Отчество: ");
                    string surname = Console.ReadLine();

                    Console.Write("Мобильный телефон: ");
                    string Phone = Console.ReadLine();

                    Console.WriteLine("Адрес Дома:");
                    Adress homeAdress = SetAdress();
                    Console.WriteLine("Адрес Работы:");
                    Adress workAdress = SetAdress();

                    Name contactName = new Name { LastName = lastName, FirstName = firstName, Surname = surname };
                    contacts[i] = new ContactBook(contactName, Phone, homeAdress, workAdress);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка формата ввода. Пожалуйста, введите корректные данные.");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                    i--;
                }
            }

            Console.WriteLine("\nЗаписи в записной книжке:");
            foreach (var contact in contacts)
            {
                Console.WriteLine("\nФИО:" + " " + contact.FIO_Name.GetFullName());
                Console.WriteLine("Мобильный телефон:" + " " + contact.PhoneNumber);
                Console.WriteLine("Домашний адрес:" + " " + contact.HomeAdress.GetAdress());
                Console.WriteLine("Рабочий адрес:" + " " + contact.WorkAdress.GetAdress());
            }
        }
    }
}
