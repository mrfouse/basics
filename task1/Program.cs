string again = "д";
while (again == "д")
{
    double a;
    double b;
    double total;
    char oper;

    Console.WriteLine("введите 1 число");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("введите оператор");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("введите 2 число");
    b = Convert.ToDouble(Console.ReadLine());

    if (oper == '+')
    {
        total = a + b;
        Console.WriteLine("сумма " + a + " и " + b + " равна " + total + ".");
    }

    else if (oper == '-')
    {
        total = a - b;
        Console.WriteLine("разность " + a + " и " + b + " равна " + total + ".");
    }

    else if (oper == '*')
    {
        total = a * b;
        Console.WriteLine("умножение " + a + " и " + b + " равно " + total + ".");
    }

    else if (oper == '/')
    {
        total = a / b;
        Console.WriteLine("дление " + a + " и " + b + " равно " + total + ".");
    }

    else if (oper == '%')
    {
        total = a % b;
        Console.WriteLine("остаток " + a + " и " + b + " равен " + total + ".");
    }

    else
    {
        Console.WriteLine("неизвестный оператор");
    }
    Console.WriteLine("нажмите (д) если хотите продолжить работу в калькуляторе.");
    again = Convert.ToString(Console.ReadLine());

}
