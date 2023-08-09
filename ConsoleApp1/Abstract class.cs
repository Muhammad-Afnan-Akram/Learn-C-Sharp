using System;
/*In this example, the Shape class represents an abstract class with all the properties you mentioned. 
 * The Circle and Square classes derive from the Shape class and demonstrate various aspects such as property implementation, 
 * constructor chaining, and abstract method implementation. The Program class demonstrates the usage of these classes
 * and their properties.

- Can have both abstract (unimplemented) and non-abstract (implemented) methods and properties.
- Support single inheritance, meaning a class can inherit from only one abstract class.
- Can have fields, properties, constructors, and methods with varying access modifiers.
- Can participate in constructor chaining, allowing derived classes to call constructors of the base abstract class.
- Provide a way to share behavior with both default implementations and placeholders for derived classes to override.
- Serve as a blueprint for classes with shared behavior and may have default implementations for common methods.
- Often used when creating base classes in class hierarchies with shared behavior.
- Abstract classes are used when you want to define a base class with both default implementations and placeholders 
for overridden methods.*/


/*using System;

abstract class Shape
{
    // Abstract property
    public abstract string Name { get; set; }

    // Non-abstract property
    public int Sides { get; set; }

    // Constructor
    protected Shape(int sides)
    {
        Sides = sides;
    }

    // Non-abstract method with varying access modifiers
    public void DisplayInfo()
    {
        Console.WriteLine($"Shape: {Name}, Sides: {Sides}");
    }

    // Abstract method
    public abstract double CalculateArea();
}

class Circle : Shape
{
    // Concrete implementation of the abstract property
    public override string Name { get; set; } = "Circle";

    // Constructor chaining to the base abstract class constructor
    public Circle(double radius) : base(sides: 0)
    {
        Radius = radius;
    }

    // Non-abstract property in the derived class
    public double Radius { get; set; }

    // Concrete implementation of the abstract method
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Square : Shape
{
    // Concrete implementation of the abstract property
    public override string Name { get; set; } = "Square";

    // Constructor chaining to the base abstract class constructor
    public Square(double sideLength) : base(sides: 4)
    {
        SideLength = sideLength;
    }

    // Non-abstract property in the derived class
    public double SideLength { get; set; }

    // Concrete implementation of the abstract method
    public override double CalculateArea()
    {
        return Math.Pow(SideLength, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(radius: 5);
        Square square = new Square(sideLength: 4);

        circle.DisplayInfo(); // Output: Shape: Circle, Sides: 0
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}"); // Output: Circle Area: 78.53981633974483

        square.DisplayInfo(); // Output: Shape: Square, Sides: 4
        Console.WriteLine($"Square Area: {square.CalculateArea()}"); // Output: Square Area: 16
    }
}
*/