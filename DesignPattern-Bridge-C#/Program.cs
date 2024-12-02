using System;
using System.Collections.Generic;

/// <summary>
/// Interface for bridge abstraction that defines a contract for rendering.
/// </summary>
public interface IDrawing
{
    void Render();
}

/// <summary>
/// Concrete implementation of the drawing abstraction.
/// </summary>
public class Circle : IDrawing
{
    public void Render() => Console.WriteLine("Rendering Circle...");
}

/// <summary>
/// Another concrete implementation of the drawing abstraction.
/// </summary>
public class Square : IDrawing
{
    public void Render() => Console.WriteLine("Rendering Square...");
}

/// <summary>
/// Abstract class that uses the bridge pattern to decouple abstraction from its implementation.
/// </summary>
public abstract class Shape
{
    protected IDrawing _drawing;

    /// <summary>
    /// Constructor to inject the drawing implementation.
    /// </summary>
    /// <param name="drawing">The IDrawing implementation.</param>
    public Shape(IDrawing drawing)
    {
        _drawing = drawing;
    }

    /// <summary>
    /// Method to display the shape.
    /// </summary>
    public abstract void Display();
}

/// <summary>
/// Concrete class that uses the bridge pattern for a specific shape type.
/// </summary>
public class CircleShape : Shape
{
    public CircleShape(IDrawing drawing) : base(drawing) { }

    /// <summary>
    /// Renders the circle using the injected drawing implementation.
    /// </summary>
    public override void Display()
    {
        Console.WriteLine("Drawing a Circle Shape.");
        _drawing.Render();
    }
}

/// <summary>
/// Concrete class that uses the bridge pattern for another shape type.
/// </summary>
public class SquareShape : Shape
{
    public SquareShape(IDrawing drawing) : base(drawing) { }

    /// <summary>
    /// Renders the square using the injected drawing implementation.
    /// </summary>
    public override void Display()
    {
        Console.WriteLine("Drawing a Square Shape.");
        _drawing.Render();
    }
}

/// <summary>
/// Main program to demonstrate the bridge pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    public static void Main()
    {
        // Create a circle shape with a circle drawing.
        Shape circle = new CircleShape(new Circle());
        circle.Display();

        // Create a square shape with a square drawing.
        Shape square = new SquareShape(new Square());
        square.Display();
    }
}
