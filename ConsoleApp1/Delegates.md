# Multiclass and Multicast Delegates in C#

In C#, the terms "multiple delegates" and "multicast delegates" are often used interchangeably to refer to a single delegate that points to multiple methods. However, let's clarify the distinction between the two terms and provide a code example to demonstrate the concept.

## Multiple Delegates

The term "multiple delegates" refers to having multiple separate delegate instances, each pointing to a different method. These individual delegates are not combined into a single delegate. They are distinct and can be invoked separately.

## Multicast Delegates

The term "multicast delegate" refers specifically to a single delegate instance that combines references to multiple methods. When a multicast delegate is invoked, it calls all the referenced methods in sequence.

## Code Example

Let's illustrate the difference between multiple delegates and a multicast delegate with a code example:

```csharp
using System;

delegate void SimpleDelegate();

class Program
{
    static void Main(string[] args)
    {
        // Creating multiple delegates (not multicast)
        SimpleDelegate delegate1 = Method1;
        SimpleDelegate delegate2 = Method2;

        // Invoking individual delegates
        delegate1();  // Output: Method1
        delegate2();  // Output: Method2

        Console.WriteLine();

        // Creating a multicast delegate
        SimpleDelegate multicastDelegate = delegate1 + delegate2;

        // Invoking the multicast delegate
        multicastDelegate();  // Output: Method1, Method2
    }

    static void Method1()
    {
        Console.WriteLine("Method1");
    }

    static void Method2()
    {
        Console.WriteLine("Method2");
    }
}
```
**Multiclass Delegates:** Refers to separate delegate instances, each pointing to different methods. They are not combined and can be invoked individually.

**Multicast Delegates:** Refers to a single delegate instance that combines references to multiple methods. When invoked, it calls all the referenced methods in sequence.