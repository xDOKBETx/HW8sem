﻿/* Задача 62: Заполните спирально массив 4 на 4.
*/

int[,] GetSpiral(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;

        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= array.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > array.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

int[,] myArray = GetSpiral(4, 4);
PrintArray(myArray);

