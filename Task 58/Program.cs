// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int rowsA = 3;
int columnsA = 4;
int rowsB = 4;
int columnsB = 3;
int[,] FirstMatrix = new int[rowsA, columnsA];
int[,] SecondMatrix = new int[rowsB, columnsB];
FillFirst(FirstMatrix);
PrintFirst(FirstMatrix);
Console.WriteLine();
FillSecond(SecondMatrix);
PrintSecond(SecondMatrix);
Console.WriteLine();
Power();


void FillFirst(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsA; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}
void PrintFirst(int[,] array)
{
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsA; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void FillSecond(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < rowsB; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}
void PrintSecond(int[,] array)
{
    for (int i = 0; i < rowsB; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Power()
{
    if (columnsA != rowsB)
    {
        Console.WriteLine("Эти две матрицы невозможно перемножить");
    }
    int[,] MatrixPower = new int[rowsA, columnsB];
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            for (int k = 0; k < rowsA; ++k)
            {
                MatrixPower[i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
            }
        }
        Console.WriteLine();
    }
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            Console.Write(MatrixPower[i, j] + "\t");
        }
        Console.WriteLine();
    }
}