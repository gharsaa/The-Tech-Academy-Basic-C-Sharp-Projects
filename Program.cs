using System;



namespace OperatorOverloadAssignment

{

    class Program

    {

        static void Main(string[] args)

        {

            // Initialize first Employee instance

            Employee emp1 = new Employee()

            {

                Id = 1,

                FirstName = "John",

                LastName = "Smith"

            };



            // Initialize second Employee instance

            Employee emp2 = new Employee()

            {

                Id = 1,

                FirstName = "Jane",

                LastName = "Doe"

            };



            // Compare both objects using the overloaded equality operator

            bool areEqual = emp1 == emp2;



            // Output the comparison result to the console

            Console.WriteLine("Are the employees equal? " + areEqual);



            // Prevent the console window from closing immediately

            Console.ReadLine();

        }

    }

}

