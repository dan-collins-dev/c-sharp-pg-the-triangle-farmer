namespace TheTriangleFarmer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculate Area of Triangle");
        Console.WriteLine("==========================");
        Console.Write("Enter the triangle's base size: ");
        string baseInput = Console.ReadLine();
        
        Console.Write("Enter the height: ");
        string heightInput = Console.ReadLine();

        double area = (Convert.ToDouble(baseInput) * Convert.ToDouble(heightInput)) / 2;

        Console.WriteLine("The area of the triangle is: " + area);
    }
}
