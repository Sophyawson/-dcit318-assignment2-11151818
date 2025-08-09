using System;

namespace ShapeApp
{
    // Abstract base class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Circle class
    public class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return 3.14159 * Radius * Radius;
        }
    }

    // Rectangle class
    public class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        // Method to safely get a positive number from the user
        static double GetPositiveNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("SHAPE APPLICATION");

            // Circle
            double radius = GetPositiveNumber("Enter radius of the circle: ");
            Circle circle = new Circle(radius);
            Console.WriteLine("Area of the circle: " + circle.GetArea());

            Console.WriteLine();

            // Rectangle
            double width = GetPositiveNumber("Enter width of the rectangle: ");
            double height = GetPositiveNumber("Enter height of the rectangle: ");
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Area of the rectangle: " + rectangle.GetArea());
        }
    }
}




