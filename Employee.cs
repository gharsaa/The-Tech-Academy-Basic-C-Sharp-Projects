
using System;



namespace PolymorphismAssignment

{

    // Employee inherits from Person and implements IQuittable

    public class Employee : Person, IQuittable

    {

        // Unique identifier for the employee

        public int Id { get; set; }



        // Provides implementation for the abstract SayName method

        public override void SayName()

        {

            Console.WriteLine("Name: " + firstName + " " + lastName);

        }



        // Implements the Quit method defined in the interface

        public void Quit()

        {

            Console.WriteLine(firstName + " has resigned from the position.");

        }

    }

}