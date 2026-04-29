using System;

// class for doing math actions
class MathOperations
{
    // method with 2 number inputs
    public void DoMath(int firstNumber, int secondNumber)
    {
        // multiply first number by 2
        int result = firstNumber * 2;

        // print the multiplied answer
        Console.WriteLine("First number multiplied by 2 = " + result);

        // print the second number
        Console.WriteLine("Second number = " + secondNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // create object from class
        MathOperations math = new MathOperations();

        // run method with regular values
        math.DoMath(5, 10);

        // run method using named values
        math.DoMath(firstNumber: 7, secondNumber: 20);

        // pause before closing
        Console.ReadLine();
    }
}