// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размерность");
int length = int.Parse(Console.ReadLine()!);
int[,] array = new int[length, length];
int number = 1;
int i = 0;
int j = 0;
while (number <= length * length)
{
    array[i, j] = number;
    if (i <= j + 1 && i + j < length - 1)
        j++;
    else if (i < j && i + j >= length - 1)
        i++;
    else if (i >= j && i + j > length - 1)
        j--;
    else
        i--;
    number++;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);