// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] InitMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] mtrx = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i, j] = rnd.Next(0, 10);
        }
    }
    return mtrx;
}
void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SummLine(int[,] matrix)
{
    int index = 0;
    int minsumm = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        if (i == 0)
        {
            minsumm = summ;
        }
        else if (summ < minsumm)
        {
            minsumm = summ;
            index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {index + 1} ");
}
Console.WriteLine("Введите кол-во строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine("----------------------");
//int[,] resultMtrx = ChangeArray(matrix, m, n);
SummLine (matrix);