using System;

class Program
{
    static void Main()
    {
        // starting message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // get weight from user
        Console.WriteLine("Please enter the package weight:");
        decimal weightInput = Convert.ToDecimal(Console.ReadLine());

        // check weight limit
        if (weightInput > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // get width
        Console.WriteLine("Please enter the package width:");
        decimal widthInput = Convert.ToDecimal(Console.ReadLine());

        // get height
        Console.WriteLine("Please enter the package height:");
        decimal heightInput = Convert.ToDecimal(Console.ReadLine());

        // get length
        Console.WriteLine("Please enter the package length:");
        decimal lengthInput = Convert.ToDecimal(Console.ReadLine());

        // total size check
        decimal sizeCheck = widthInput + heightInput + lengthInput;

        if (sizeCheck > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // do the math for price
        decimal price = (widthInput * heightInput * lengthInput * weightInput) / 100;

        // print result
        Console.WriteLine("Your estimated total for shipping this package is: $" + price.ToString("0.00"));

        // goodbye message
        Console.WriteLine("Thank you!");
    }
}