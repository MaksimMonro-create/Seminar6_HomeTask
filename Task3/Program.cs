// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.Clear();
Console.WriteLine();

int[,] GetArray(int row, int column, int min, int max)   // метод создания массива
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[,] ChangeToSquare(int[,] arr) // метод создания нового массива с замененными элементами
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
            else arr[i, j] = arr[i, j];
        }
    }
    return arr;
}

void PrintArray(int[,] array)      // метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($" {array[i, j]}   ");
            else Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int row = 7;
int column = 7;
int min = 1;
int max = 10;

int[,] mainArray = GetArray(row, column, min, max);
PrintArray(mainArray);
Console.WriteLine("--------");
int[,] chagedArray = ChangeToSquare(mainArray);
PrintArray(chagedArray);
