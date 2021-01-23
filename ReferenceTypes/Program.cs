using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Harun";
            person2 = person1;
            person1.FirstName = "ali"; //person2 = ali 
            /*value is not equals but referances is equals*/
            
            //Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "ayse";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();

            // customer = employee cannot be equals 

            Person person3 = new Person();
            person3 = customer; // is true , because customer is a person -inheritance-
            //Console.WriteLine(person3.FirstName);

            //person3.CreditNumber /* we can't see custumer's propertys but we can custumer boxing ... let we see*/
            //Console.WriteLine(((Customer)person3).CreditCardNumber);// woww ! we can see now

            employee.FirstName = "murat";
            person3.FirstName = "leyla";

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employee);
            personManager.Add(person3);
        }
    }

    class Person //base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }


    }

    class PersonManager
    {
        public void Add(Person person) 
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
