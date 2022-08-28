/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] CreateMatrix(int row, int column)
{
    double[,] matrix = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().NextDouble() * 1000;
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
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

Console.Write("Веедите колличество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите колличество строк в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = CreateMatrix(row, column);
PrintMatrix(matrix);