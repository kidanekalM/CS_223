namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            double radius = Double.Parse(Console.ReadLine());
            Circle c = new(radius);
            Console.WriteLine("Area : "+ c.calculateArea());
            Console.WriteLine("Perimeter : " + c.calculatePerimeter());

            Console.WriteLine("Enter the length");
            double l = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            double w = Double.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(w, l);
            Console.WriteLine("Area is "+ r.calculateArea());  
            Console.WriteLine("Perimeter is "  + r.calculatePerimeter());

        }
    }
}