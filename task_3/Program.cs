internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double i = Math.Sqrt(x * 2 - 1);
        double num = x / i;
        Console.WriteLine("ответ:");
        Console.WriteLine(num);
    }
}
