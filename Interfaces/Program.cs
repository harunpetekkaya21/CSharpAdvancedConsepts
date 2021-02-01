using System;

namespace Interfaces
{
    class Program
    {
        
        //interface new lenemez
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
           // employeeManager.Add();


            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //musteri ekleme kodlari
            Console.WriteLine("Musteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Guncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Stajyer Guncellendi");

        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
