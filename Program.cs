// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using shape_area.Shapes;

public class Program
{
    static void Main(string[] args)
    {
        //shapes list 
        string[] shapes = { "Square", "Rectangle", "Triangle", "Circle", "Sphere" };

        double areaResult = 0.0;

        Console.WriteLine($"Area Calculation {Environment.NewLine}");
        Console.WriteLine($"Select the shape from 1 - {shapes.Length}");


        //draw menu options
        for (int index = 0; index < shapes.Length; index++)
        {
            Console.WriteLine($"{index+1} - {shapes[index]}");
        }

        Console.WriteLine($"{Environment.NewLine}");

        var selectedShape = Console.ReadLine();
        var selectedShapeInt = Convert.ToInt32(selectedShape);

        var shapeName = shapes[selectedShapeInt-1]; //shapesDB.Keys.ElementAt(selectedShape+1);


        if (shapeName == "Square")
        {
            Console.WriteLine($"Enter the length of the {shapeName}");
            var length = Convert.ToInt32(Console.ReadLine());

            Square square = new Square(length);
            areaResult = square.Area();

        }

        if (shapeName == "Rectangle")
        {
            Console.WriteLine($"Enter the height of the {shapeName}");
            var height  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the width of the {shapeName}");
            var width = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(height, width);
            areaResult = rectangle.Area();

        }

        if (shapeName == "Triangle")
        {
            Console.WriteLine($"Enter the height of the {shapeName}");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the width of the {shapeName}");
            var width = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(height,width);
            areaResult = rectangle.Area();

        }

        if (shapeName == "Circle")
        {
            Console.WriteLine($"Enter the radius of the {shapeName}");
            var radius = Convert.ToInt32(Console.ReadLine());

            Circle circle = new Circle(radius);
            areaResult = circle.Area();
        }

        if (shapeName == "Sphere")
        {
            Console.WriteLine($"Enter the radius of the {shapeName}");
            var radius = Convert.ToInt32(Console.ReadLine());

            Sphere rectangle = new Sphere(radius);
            areaResult = rectangle.Area();
        }

        Console.WriteLine($"The area of the {shapeName} equals {areaResult}");
        
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }
}

