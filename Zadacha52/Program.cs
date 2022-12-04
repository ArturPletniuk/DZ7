// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random RandomNumber = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = RandomNumber.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]},  ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("|");
    }
}
double[] ArithmeticMean(int[,] matrix, int numberElements, int numberRows)
{
    double[] array = new double[numberElements];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double number = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            number += matrix[i, j];
        }
        number /= numberRows;
        number = Math.Round(number, 1);
        array[j] = number;
    }
    return array;
}
void PrintArray(double[] list)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < list.Length; i++)
    {
        if (i < list.Length - 1) Console.Write($"{list[i]}; ");
        else Console.Write($"{list[i]}");
    }
}
int line = 3;
int column = 5;
int[,] arra2d = CreateMatrixRndInt(line, column, 1, 10);
PrintMatrix(arra2d );
double[] array = ArithmeticMean(arra2d , column, line);
PrintArray(array);
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();
