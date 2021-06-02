using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Исходные данные:");
            Console.ResetColor();
            foreach (var info in phoneBook)
                Console.WriteLine(info.Name + " " + info.LastName + " " + info.PhoneNumber + " " + info.Email);

            //чтобы контакты телефонной книги были отсортированы сперва по имени, а затем по фамилии.
            
            var sortedBook = phoneBook.OrderBy(pb => pb.Name).ThenBy(pb => pb.LastName);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Отсортированные данные сперва по имени, а затем по фамилии:");
            Console.ResetColor();
            foreach (var info in sortedBook )
                Console.WriteLine(info.Name + " " + info.LastName + " " + info.PhoneNumber + " " + info.Email );
        }
    }
   
}
