/*  We define an interface IShape with a property signature Area and a method signature CalculateArea().
We implement the IShape interface in two classes: Circle and Rectangle.
Both Circle and Rectangle provide implementations for the Area property and the CalculateArea() method.
The Main method creates instances of Circle and Rectangle, calculates their areas, and displays the results.
This example demonstrates how interfaces define contracts (property and method signatures) that unrelated classes must adhere to, 
promoting loose coupling between classes while allowing them to share a common contract.

- Declare only method and property signatures without any implementation details.
- Support multiple inheritance, allowing a class to implement multiple interfaces.
- Can only declare methods and properties with implicit public access modifiers.
- Do not have constructors, fields, or properties with implementation.
- Do not participate in constructor chaining.
- Define contracts that unrelated classes must adhere to by implementing all the methods and properties declared in the interface.
- Promote loose coupling between classes, allowing unrelated classes to share a common contract.
- Interfaces are used when you want to define a contract for unrelated classes, allowing them to share a 
common set of methods and properties.*/

/*using System;

// Define an interface named IShape
interface IShape
{
    // Declare a property signature
    double Area { get; }

    // Declare a method signature
    void CalculateArea();
}

// Implement the IShape interface in the Circle class
class Circle : IShape
{
    // Implement the Area property
    public double Radius { get; set; }
    public double Area { get; private set; }

    // Implement the CalculateArea method
    public void CalculateArea()
    {
        Area = Math.PI * Radius * Radius;
    }
}

// Implement the IShape interface in the Rectangle class
class Rectangle : IShape
{
    // Implement the Area property
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area { get; private set; }

    // Implement the CalculateArea method
    public void CalculateArea()
    {
        Area = Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Circle instance
        Circle circle = new Circle { Radius = 5 };
        circle.CalculateArea(); // Calculate the area

        // Create a Rectangle instance
        Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };
        rectangle.CalculateArea(); // Calculate the area

        // Display the calculated areas
        Console.WriteLine($"Circle Area: {circle.Area}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area}");
    }
}
*/
//Outputter:
//Circle Area: 78.53981633974483
//Rectangle Area: 24
