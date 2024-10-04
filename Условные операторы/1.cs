try
{
    Console.WriteLine("Введите свой рост");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите свой вес");
    double y = double.Parse(Console.ReadLine());
    if (x == 100 && y <= 50) Console.WriteLine("У вас нормальный вес ничего делать не нужно");
    else Console.WriteLine("Ты жирный иди худей");
}
catch
{
    Console.WriteLine("Введите правильные значение ");
}