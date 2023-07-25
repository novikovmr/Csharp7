/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int fCount(int[,] matrix, int[] pos)
{
    int count = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == pos[0] && j == pos[1])
                {
                    count = matrix[i, j];
                }
        }
    }
    return count;
}

void Condition(int count)
{
    if (count != -1) Console.WriteLine(count);
    else Console.WriteLine("Такого числа в массиве нет");
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();
Console.Write("Введите позицию элемента: ");
int[] pos = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
InputMatrix(matrix);
Console.WriteLine();
int count = fCount (matrix, pos);
Condition(count);