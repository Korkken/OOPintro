// Tim Lappalainen NET2024


Console.WriteLine("Skriv in vad du vill ha för radien på cirkeln");
int radius;
while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0) // checking if the user put in a valid number
{
    Console.WriteLine("Skriv in en siffra eller ett tal som är större än 0");
}
Circle circle = new Circle(radius);
double area = Math.Round(circle.GetArea(), 2); // calculating the area and rounding it to 2 decimals
Console.WriteLine($"Arean av cirkeln med radien {radius} är: {area}");

class Circle
{
    public int Radius;
    public Circle(int radius)
    {
        Radius = radius;
    }
    public double GetArea() //method to generate area of the radius that the user gave.
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

}

