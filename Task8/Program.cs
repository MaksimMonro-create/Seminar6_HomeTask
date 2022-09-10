// В ПРЯМОУГОЛЬНОЙ МАТРИЦЕ НАЙТИ СТРОКУ С НАИМЕНЬШЕЙ СУММОЙ ЭЛЕМЕНТОВ

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int rowNumber(int[,] array)
{
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            index = i;
        }
    }
    return index;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int row = 7;
int col = 13;
int min = 1;
int max = 10;

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
Console.WriteLine("---");
int index = rowNumber(matrix);
Console.WriteLine(index);