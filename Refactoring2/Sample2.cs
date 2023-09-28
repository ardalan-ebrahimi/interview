public class Shape
{
    public string Type { get; set; }

    public double Area()
    {
        if (Type == "Circle")
        {
            double radius = 5;
            return Math.PI * radius * radius;
        }
        else if (Type == "Rectangle")
        {
            double width = 4;
            double height = 6;
            return width * height;
        }
        return 0;
    }
}

class Program_Example2
{
    static void Main()
    {
        var circle = new Shape { Type = "Circle" };
        var rectangle = new Shape { Type = "Rectangle" };

        Console.WriteLine($"Circle Area: {circle.Area()}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
    }
}
