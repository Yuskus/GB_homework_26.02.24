// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

void Main()
{
    char[,] symbols = GenerateCharArray(4, 7);
    PrintCharArray(symbols);
    Console.WriteLine(CharToString(symbols));
}

char[,] GenerateCharArray(int row, int col)
{
    char[,] symb = new char[row,col];
    Random rand = new();
    for (int i = 0; i < symb.GetLength(0); i++)
        for (int j = 0; j < symb.GetLength(1); j++)
            symb[i,j] = (char)rand.Next(97, 123);
    return symb;
}

void PrintCharArray(char[,] array)
{
    Console.Write("My char array: ");
    foreach (char a in array) 
        Console.Write(a + " ");
    Console.WriteLine();
}

string CharToString(char[,] array)
{
    string line = "";
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            line += array[i,j];
    return line;
}

Main();