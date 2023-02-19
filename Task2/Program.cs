// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] InitMatrix()
{
    int[,] array = new int[2,4];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ReadInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PositionMatrix (int [,] arr, int rows, int colums)
{
    if (rows < arr.GetLength(0) && colums < arr.GetLength(1)) Console.WriteLine(arr[rows, colums]);
    else Console.WriteLine($"{rows}, {colums} - такого числа в массиве нет");
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
int i = ReadInt ("Введите номер строки: ");
int j = ReadInt ("Введите номер столбца: ");
PositionMatrix(matrix, i, j);

