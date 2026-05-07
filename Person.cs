
using System;



namespace PolymorphismAssignment

{

    // Abstract base class representing a general person

    public abstract class Person

    {

        // Basic properties for a person's name

        public string firstName { get; set; }

        public string lastName { get; set; }



        // Abstract method that must be implemented by derived classes

        public abstract void SayName();

    }

}
