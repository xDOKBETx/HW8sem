/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

Console.Write("Ввелите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввелите начало диапазона: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int last = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int RowMinimumSum(int[,] array)
{
    int minIndex = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum || minSum <= 0)
        {
            minSum = sum;
            minIndex = i++;
        }
    }
    return minIndex;
}

int[,] array = GetArray(row, col, first, last);
PrintArray(array);
Console.WriteLine();
Console.Write($"Индекс строки двумерного массива с наименьшей суммой элементов: {RowMinimumSum(array)}");
