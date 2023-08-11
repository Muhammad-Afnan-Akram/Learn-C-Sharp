using System;

class Program
{
    delegate int MathOperation(int a, int b);

    static void Main(string[] args)
    {
        MathOperation operation1 = Add;
        MathOperation operation2 = Subtract;

        MathOperation combined = operation1 + operation2;
       
        Console.WriteLine("operation1: "+operation1(2,5));
        Console.WriteLine("Operation2: " + operation2(6,3));
        Console.WriteLine("Combined"+combined);

       /* combined += Multiply;

        int result = combined(10, 2);  // Result: 40

        Console.WriteLine("Final Result: " + result);*/
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
