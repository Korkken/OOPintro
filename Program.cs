// Tim Lappalainen NET2024


Console.WriteLine("Enter the radius of the circle:");
int radius = int.Parse(Console.ReadLine());
Circle circle = new Circle(radius);
double area = Math.Round(circle.GetArea(), 2);
Console.WriteLine($"The area of the circle with radius {radius} is: {area}");

class Circle
{
    public int Radius { get; set; }
    public Circle(int radius)
    {
        Radius = radius;
    }
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

}

