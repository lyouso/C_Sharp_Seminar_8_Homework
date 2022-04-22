// Заполните спирально массив 4 на 4 числами от 1 до 16.
int rows = 4;
int columns = 4;
int count = 1;
int lastIndexJ = columns - 1;
int lastIndexI = rows - 1;
int[,] array = new int[rows, columns];
FillArray();
PrintArray();

void FillArray()

{
    for (int j = 0; j < columns; j++)
    {
        array[0, j] = count;
        count++;
    }
    for (int i = 1; i < rows; i++)
    {
        array[i, lastIndexJ] = count;
        count++;
    }
    for (int j = lastIndexJ - 1; j >= 0; j--)
    {
        array[lastIndexI, j] = count;
        count++;
    }
    for (int i = lastIndexI-1; i >= 1; i--)
    {
        array[i, 0] = count;
        count++;
    }
    for (int j = 1; j < lastIndexJ; j++)
    {
        array[1, j] = count;
        count++;
    }
    for (int j = 2; j > 0; j--)
    {
        array[2, j] = count;
        count++;
    }


}



void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}