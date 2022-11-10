// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Clear();

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int x = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = x;
    }
}

void PrintChangeArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int[,] matrix = new int[4, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);
PrintChangeArray(matrix);