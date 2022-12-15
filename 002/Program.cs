// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.  y = k1 * (b2-b1) / (k1 - k2) + b
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintArray(double[] arr)
{
    Console.WriteLine("Вывод массива");
    foreach (double el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2); // x
    point[1] = k1 * (b2 - b1) / (k1 - k2) + b1; // y
    return point;
}
try
{
    Console.WriteLine("Введите число b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число b2");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    if (k1 != k2)
    {
        double[] array = IntersectionPoint(b1, k1, b2, k2);
        Console.WriteLine("Точка пересечения прямых: ");
        PrintArray(array);
    }
    else Console.WriteLine("Индексы k1 = k2. Прямые не пересекаются. ");
}
catch
{
    Console.WriteLine("Ошибка! Проверьте вводимые данные.");
}