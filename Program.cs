/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.*/

Console.Clear();

void PrintInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int GetDataFromUser(string message)
{
    PrintInColor(message, ConsoleColor.Blue);
    int result = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    return result;
}

int[,] GetArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        PrintInColor(j + "\t", ConsoleColor.Green);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t", ConsoleColor.Green);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement(int[,] array, int row, int col)
{
    if (-1 < row && row < 10)
    {
        if (-1 < col && col < 10)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == row && j == col)
                    {
                        Console.WriteLine($"Значение искомого элемента = {array[i, j]}.");
                    }
                }
            }
        }
    }
    else
    {
        Console.WriteLine($"В массиве нет элемента на данной позиции.");
    }
}

int[,] array = GetArray(10, 10, 0, 99);
PrintArray(array);
int row = GetDataFromUser("Введите строку: ");
int col = GetDataFromUser("Введите столбец: ");
FindElement(array, row, col);