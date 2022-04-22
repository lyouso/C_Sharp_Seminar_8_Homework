// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];
int[] summ = new int[rows];
FillArray();
PrintArray();
Console.WriteLine();
MinSumm();


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
void MinSumm()
{
    for (int i = 0; i < rows; i++)
    {
        int currentSumm = 0;
        for (int j = 0; j < columns; j++)
        {
            currentSumm += array[i, j];

            summ[i] = currentSumm;
        }
        Console.Write(summ[i] + " ");
    }
    Console.WriteLine();

    int minIndex = 0;
    int min = summ[minIndex];
    for (int i = 0; i < rows; i++)
    {
        if (summ[i] < min)
        {
            min = summ[i];
            minIndex = i;
        }
    }
    int stringNumber = minIndex+1;
    Console.WriteLine("Минимальная из всех сумм равна " + min);
    Console.WriteLine("Это сумма элементов " + stringNumber + " строки");
}