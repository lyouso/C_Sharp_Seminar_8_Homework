/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
построчно выведет элементы и их индексы. */

int a = 4;
int b = 4;
int c = 5;
int start = 10;
int[,,] array = new int[a, b, c];
FillArray(array);
PrintArray(array);


void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                array[i, j, k] = count;
                count++;
        
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                Console.WriteLine($"{i}, {j}, {k} = {array[i, j, k]}");
    
            }
        }
    }
}