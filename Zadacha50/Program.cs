// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет
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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}
int line = 4;
int column = 5;
int[,] array2d = CreateMatrixRndInt(line, column, 1, 10);
PrintMatrix(array2d);
Console.Write("Введите позицию элемента через запятую: ");
string value = Console.ReadLine()!;
string[] array = value.Split(",");
int rows = Convert.ToInt32(array[0]);
int columns = Convert.ToInt32(array[1]);
if (rows >= line | columns >= column) Console.Write("Такого элемента нет!");
else Console.WriteLine($"{array2d[rows, columns]}");
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();