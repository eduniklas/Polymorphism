# Polymorphism
School assignment

# About the task:

In this task, you will practice using polymorphism in object-oriented programming. The task primarily involves creating a polymorphism structure.

# What you need to do:

- [ ] Create a class that will serve as the parent class for the other classes that will inherit from it. The class should be named `Geometry{ }`, and it should have a method called `Area()` with a return type of `double`.
- [ ] Create five classes that will inherit from the `Geometry` class. These classes should be named `Rectangle`, `Square`, `Circle`, `Parallelogram`, and `Ellipse`. All of these classes should have a method named `Area()`.
- [ ] Each class should have at least one property, for example:

    ```csharp
    public class Circle {
         public double Radius { get; set; }
    }
    ```
    
- [ ] In all child classes, override the `Area()` method with different implementations, as the area of a circle is not calculated in the same way as the area of a square.
- [ ] All child classes must have a constructor to set values for their properties. We will provide a fixed value in the constructor, for example:

    ```csharp
    public Circle {
          Radius = 4;
    }
    ```
    
- [ ] In the `Main()` method, create an object reference from the `Geometry` class, and it should point to an object in each class.
