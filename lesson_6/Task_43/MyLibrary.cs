public class MyLibrary
{
    public static double WriteLine(string text)
    {
        Console.WriteLine(text);
        double number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    public static void Print(double b1, double k1, double b2, double k2)
    {
        double x = (-b2 + b1) / (-k1 + k2);
        double y = k2 * x + b2;
        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
}