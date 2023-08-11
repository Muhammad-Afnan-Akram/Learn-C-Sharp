using System;
/*Multiple Delegates: Refers to having separate delegate instances, each pointing to different methods.They are 
 * not combined and can be invoked individually.

Multicast Delegates: Refers to a single delegate instance that combines references to multiple methods.When invoked, 
it calls all the referenced methods in sequence.
*/
class Program
{
    // Define delegate types for integer and double operations
    delegate int MathOperation1(int a, int b);
    delegate double MathOperation2(double a, double b);

    static void Main(string[] args)
    {
        // Creating delegates for integer operations
        MathOperation1 operation1 = Add;        // Multiclass delegate (integer)
        MathOperation1 operation2 = Subtract;   // Multiclass delegate (integer)

        // Creating delegates for double operations
        MathOperation2 operation3 = Add;        // Multiclass delegate (double)
        MathOperation2 operation4 = Subtract;   // Multiclass delegate (double)

        // Creating multicast delegate by combining integer delegates
        MathOperation1 combinedInteger = operation2 + operation1;  // Multicast delegate (integer)

        // Creating multicast delegate by combining double delegates
        MathOperation2 combinedDouble = operation4 + operation3;    // Multicast delegate (double)

        // Calling and printing results for integer operations
        Console.WriteLine("operation1 (integer): " + operation1(5, 4));      // Output: 9
        Console.WriteLine("operation2 (integer): " + operation2(5, 4));      // Output: 1
        Console.WriteLine("Combined integer operations: " + combinedInteger(5, 4)); // Output: 9

        // Calling and printing results for double operations
        Console.WriteLine("operation3 (double): " + operation3(5.5, 4.5));    // Output: 10.0
        Console.WriteLine("operation4 (double): " + operation4(5.5, 4.5));    // Output: 1.0
        Console.WriteLine("Combined double operations: " + combinedDouble(5.5, 4.5)); // Output: 10.0

        // Adding the Multiply method to the integer multicast delegate
        combinedInteger += Multiply;

        // Invoking the integer multicast delegate
        int intResult = combinedInteger(10, 2);  // Result: 20
        Console.WriteLine("Final Integer Result: " + intResult);

        // Adding the Multiply method to the double multicast delegate
        combinedDouble += Multiply;

        // Invoking the double multicast delegate
        double doubleResult = combinedDouble(5.5, 2);  // Result: 11
        Console.WriteLine("Final Double Result: " + doubleResult);
    }

    // Integer addition
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Integer subtraction
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    // Double addition
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Double subtraction
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Integer multiplication
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
}
