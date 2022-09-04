/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/


int[,,] GetArray()
{
    int[] nums = new int[8];
    for (int i = 0; i < 8; i++)
    {
        int num = new Random().Next(10, 100);
        bool flag = true;
        while (flag)
        {
            flag = false;
            foreach (int n in nums)
            {
                if (n == num)
                {
                    flag = true;
                    num = new Random().Next(10, 100);
                }
            }
        }
        nums[i] = num;
    }

    int[,,] array = new int[2, 2, 2];
    int temp = 0;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = nums[temp];
                temp++;
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");

            Console.WriteLine();
        }
    }
}

PrintArray(GetArray());
