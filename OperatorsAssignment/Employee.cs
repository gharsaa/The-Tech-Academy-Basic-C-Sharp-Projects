using System;



namespace OperatorOverloadAssignment

{

    // Represents an employee entity with basic identifying information

    public class Employee

    {

        // Unique identifier for the employee

        public int Id { get; set; }



        // Employee's first name

        public string FirstName { get; set; }



        // Employee's last name

        public string LastName { get; set; }



        // Overloads the equality operator to compare Employee objects by Id

        public static bool operator ==(Employee emp1, Employee emp2)

        {

            // If both references point to the same object (or both are null), they are equal

            if (ReferenceEquals(emp1, emp2))

                return true;



            // If only one is null, they are not equal

            if (emp1 is null || emp2 is null)

                return false;



            // Equality is determined solely by matching Id values

            return emp1.Id == emp2.Id;

        }



        // Overloads the inequality operator (must be paired with ==)

        public static bool operator !=(Employee emp1, Employee emp2)

        {

            return !(emp1 == emp2);

        }



        // Overrides Equals to maintain consistency with the == operator

        public override bool Equals(object obj)

        {

            if (obj is Employee emp)

                return this.Id == emp.Id;



            return false;

        }



        // Overrides GetHashCode to align with Equals implementation

        public override int GetHashCode()

        {

            return Id.GetHashCode();

        }

    }

}
