// задача 1 HARD необязательная. Сгенерировать массив случайных целых чисел 
// размерностью m*n (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. 
// Найти минимальное число и его индекс, найти максимальное число и его индекс. 
// Вывести эту информацию на экран.

void PrintArray1(int[] arr)
{
    foreach (int el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}

void MinMax(int[,] arr)
{
    int max = arr[0,0];
    int min = arr[0,0];
    int[] max_index = new int[2];
    int[] min_index = new int[2];
    
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] > max ) 
            {
                max = arr[i,j];
                max_index[0] = i; 
                max_index[1] = j; 
            }
            if (arr[i,j] < min ) 
            {
                min = arr[i,j];
                min_index[0] = i; 
                min_index[1] = j; 
            }
        }
    
    Console.Write($"Максимальное число: {max} с индексами ");
    PrintArray1(max_index);
    Console.Write($"Минимальное число: {min} с индексами ");
    PrintArray1(min_index);
}
try
    {Console.WriteLine("Введите количество строк двумерного массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int [rows,cols];
    FillArray(array);
    Console.WriteLine("");
    PrintArray2(array);
    MinMax(array);
}
catch
{
    Console.WriteLine("Ошибка! Проверьте вводимые данные.");
}