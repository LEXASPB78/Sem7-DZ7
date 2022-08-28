/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void AverageColum(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i,j];
        }
        Console.WriteLine($"Среднее значение элементов столбца {j} = {average/matrix.GetLength(0)}");
    }
}
 
Console.Write("Веедите колличество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите колличество столбцов в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(row, column);
PrintMatrix(matrix);
AverageColum(matrix);
