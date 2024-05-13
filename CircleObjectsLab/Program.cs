Console.WriteLine("Welcome to my circle maker!");

double n;
string input;

do
{
    Console.WriteLine("Please enter the radius for the circle");
    input = Console.ReadLine().Trim();
    if (double.TryParse(input, out n)) break;
    Console.WriteLine("The radius must be a number");
} while (true);

Circle funCircle = new Circle(n);

do
{
    Console.WriteLine($"Diamter: {funCircle.CalculateDiameter()}");
    Console.WriteLine($"Circumference: {funCircle.CalculateCircumfrence()}");
    Console.WriteLine($"Area: {funCircle.CalculateArea()}");
    Console.WriteLine();
    Console.WriteLine("Should the circle grow?  Enter y or yes to grow the circle, enter anything else to exit");
    input = Console.ReadLine().Trim().ToLower();
    if (input != "yes" && input != "y")
    {
        Console.WriteLine($"Goodbye.  The circle's final radius is {funCircle.GetRadius()}");
        break;
    }
    funCircle.Grow();
    Console.WriteLine("The circle is magically growing.");
    Console.WriteLine();

} while(true);


public class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }
    public double CalculateDiameter()
    {
        return radius * 2;
    }
    public double CalculateCircumfrence()
    {
        return radius * 2 * Math.PI;
    }
    public double CalculateArea()
    {
        return radius * radius * Math.PI;
    }
    public void Grow()
    {
        radius *= 2;
    }
    public double GetRadius()
    {
        return radius;
    }
}
