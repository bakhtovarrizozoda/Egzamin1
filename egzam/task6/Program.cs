var ci = new Circle();
ci.Radius = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Age: " + ci.GetArea());
Console.WriteLine("Circumference: " + ci.GetCircumference());
Console.WriteLine("Diameter: " + ci.GetDiameter());



public class Circle
{
    public int Radius;
    public double GetArea()
    {
        return 3.14 * (Radius * Radius);
    }
    public double GetCircumference()
    {
        return 3.14 * (2 * Radius);
    }
    public double GetDiameter()
    {
        return 2 * Radius;
    }
}