// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] arr)
{
    Console.WriteLine("Вывод массива");
    foreach (int el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элементы массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PosCount (int[]arr)
{
    int count = 0;
    foreach(int el in arr)
    {
        if (el > 0 ) count++;
    }
    return count;
}
try
{    Console.WriteLine("Введите число");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(m);
    PrintArray(array);
    Console.WriteLine($"В массиве " + PosCount (array) + " положительных чисел.");
}
catch
{
    Console.WriteLine("Ошибка! Проверьте вводимые данные.");
}