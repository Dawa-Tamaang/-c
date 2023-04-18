using System;

class AddTwoDigits
{
    int num1;
    int num2;
    int result;

    // Constructor
    public AddTwoDigits(int n1, int n2)
    {
        num1 = n1;
        num2 = n2;
        result = num1 + num2;
    }

    public void PrintResult()
    {
        Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, result);
    }
}

class Program
{
    static void Main()
    {
        AddTwoDigits adder = new AddTwoDigits(7, 5);

        adder.PrintResult();
        Console.ReadLine();
    }
}
