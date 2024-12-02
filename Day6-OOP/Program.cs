using System;

 namespace OOP
 {
    // class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Person p1 = new Person("James", 21, "New York");
    //         p1.bio();
    //     }
    // }
    // class Person{
    //     private string name;
    //     private int age;
    //     private string hometown;

    //     public Person(string name, int age, string hometown){
    //         this.name = name;
    //         this.age = age;
    //         this.hometown = hometown;
    //     }

    //     public void bio(){
    //         Console.WriteLine("Name: " + name);
    //         Console.WriteLine("Age: " + age);
    //         Console.WriteLine("Hometown: " + hometown);
    //     }
    // }
    
    public abstract class Shape {
        
    public abstract double CalculateArea();

    public void DisplayShape(){
        Console.WriteLine($"This is a {this.GetType().Name}.");
    }

    }

    public class Circle : Shape{
        public double Radius{get; set;}
        public Circle(double radius)
    {
        Radius = radius;
    }
     public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    }

    public class Triangle : Shape{
        public double Base {get; set;}
        public double Height {get; set;}

        public Triangle(double baseLength, double height){
            Base = baseLength;
            Height = height;
        }
        public override double CalculateArea(){
            return 0.5 * Base * Height;
        }
    }

    public class Quad : Shape{
        public double Length {get; set;}
        public double Width {get; set;}

        public Quad(double length, double width){
            Length = length;
            Width = width;
        }

        public override double CalculateArea(){
            return Length * Width;
        }
    }

    class Program{
        static void Main(){
            Circle c1 = new Circle(5);
            Triangle t1 = new Triangle(6,4);
            Quad q1 = new Quad(5,4);

            c1.DisplayShape();
            Console.WriteLine("Circle Area: " + c1.CalculateArea());
            t1.DisplayShape();
            Console.WriteLine("Triangle Area: " + t1.CalculateArea());
            q1.DisplayShape();
            Console.WriteLine("Quad Area: " + q1.CalculateArea());
        }
    }
}