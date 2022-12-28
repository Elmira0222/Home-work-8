/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

// ввод числа
int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
    }
    return result;
}

// рандомный двумерный массив
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

// печать массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Specify Rectangular Two-Dimensional Array.");
int m = GetNumber("enter the number of lines: ");
int n = GetNumber("enter the number of columns: ");
if (m == n)
{
    Console.WriteLine("Input Error: Specify rectangular 2D array.");
}
else
{
    int[,] array = GetArray(m, n);
    Console.WriteLine("Source array:");
    PrintMatrix(array);
    /*Прога находит строку с наименьшей суммой элементов
    (считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой)
    */
    int minsumm = Int32.MaxValue; // Int32.MaxValue - наибольшее возможное значение типа Int32. является константой
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        Console.WriteLine($"Sum of row elements {i}: {summ}    ");
        if (summ < minsumm)
        {
            minsumm = summ;
            row=i;
        }
    }
    Console.WriteLine($"The row with the smallest sum of elements: {row}, where is the sum of the elements = {minsumm}");
}


