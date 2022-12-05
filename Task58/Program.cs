// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
Console.WriteLine("Обязательное условие: число столбцов первой равно число строк второй либо матрица прямоугольная");
Console.WriteLine("Введите кол-во строк первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = InitMatrix(m1, n1);
int[,] matrix2 = InitMatrix(m2, n2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
Console.WriteLine("----------------------");
int[,] resMtrx = ResultMatrix(m1, n2);
PrintMatrix(resMtrx);
if (matrix2.GetLength(0) != matrix1.GetLength(1))
{
    Console.WriteLine(" произведение двух матриц выполнить нельзя ");
    return;
}

int[,] ResultMatrix()
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        int[,] resultArray = new int[m1, n2];
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            resultArray[i, j] += matrix2[i, matrix1.GetLength(1)] * matrix1[matrix1.GetLength(0), matrix1.GetLength(1) + 1];
        }
        return resultArray; 
    }
}