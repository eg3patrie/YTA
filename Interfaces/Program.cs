using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 5,
                Name = "Ata",
                LastName = "Yurt",
                Adress = "Bursa"
            };

            Student student = new Student()
            {
                Id = 5,
                Name = "Ege",
                LastName = "Yurt",
                Departmant = "Maths"
            };

            manager.Add(student);
            manager.Add(customer);
            Console.ReadLine();
        }
        interface IPerson
        {
            int Id { get; set; }
            string Name { get; set; }
            string LastName { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }


        class Customer : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }

            public string Adress { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine("Adı:" + person.Name +"----------"+ "Soyadı:"+person.LastName+"--------" +"Id:"+ person.Id);
            }
        }
    }
}
