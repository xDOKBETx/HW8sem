/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/


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


int[,] GetMultiMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < secondArray.GetLength(0); k++)
            {
                result[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return result;
}
int[,] firstArray = GetArray(4, 2, 0, 10);
int[,] secondArray = GetArray(2, 5, 0, 10);
if (firstArray.GetLength(1) != secondArray.GetLength(0))
{
    Console.WriteLine("Найти произведение матриц невозможно!");
}
else
{
    int[,] thirdArray = GetMultiMatrix(firstArray, secondArray);
    PrintArray(firstArray);
    Console.WriteLine();
    PrintArray(secondArray);
    Console.WriteLine();
    PrintArray(thirdArray);
}
