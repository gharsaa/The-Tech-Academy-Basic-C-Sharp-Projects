
using System;



namespace PolymorphismAssignment

{

    class Program

    {

        static void Main(string[] args)

        {

            // Instantiate an Employee object with sample data

            Employee emp = new Employee()

            {

                firstName = "John",

                lastName = "Smith",

                Id = 1

            };



            // Call the overridden method from the base class

            emp.SayName();



            // Demonstrate polymorphism using the interface reference

            IQuittable quittableEmp = emp;



            // Invoke the Quit method through the interface

            quittableEmp.Quit();



            // Keep the console window open

            Console.ReadLine();

        }

    }

}

