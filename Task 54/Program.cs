// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];
FillArray();
PrintArray();
Console.WriteLine();
Sort();


void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Sort()
{
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                int change = 0;
                if (array[i, j] < array[i, j + 1])
                {
                    change = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = change;
                }
            }
        }
    }
    PrintArray();
}