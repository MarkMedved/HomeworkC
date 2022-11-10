// **Задача HARD SORT ** 
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

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

int[] ConvertToList(int[,] matrix)
{
    int[] array1 = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int m = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array1[m] = matrix[i, j];
            m++;
        }
    }
    return array1;
}

void BubblerSoft(int[,] matrix)
{
    int x= 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (matrix[i,j]<= matrix[k,l])
                    {
                        x= matrix[i,j];
                    matrix[i,j] = matrix[k,l];
                    matrix[k,l] =x;
                    }
        
                }
            }
        }
    }
}

Console.WriteLine();
int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
BubblerSoft(matrix);
PrintArray(matrix);
