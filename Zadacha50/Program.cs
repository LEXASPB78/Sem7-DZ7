/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] CreateMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindElement(int row, int column, int[,] matrix)
{
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
        Console.Write($"Элемент matrix[{row},{column}] в данном массиве = {matrix[row, column]}");
    else Console.Write($"Элемента matrix[{row},{column}] в данном массиве нет ");
}

Console.Write("Веедите колличество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите колличество столбцов в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(row, column);
PrintMatrix(matrix);

Console.Write("Веедите искомую строку элемента: ");
row = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите искомый столбец элемента: ");
column = Convert.ToInt32(Console.ReadLine());
FindElement(row, column, matrix);
