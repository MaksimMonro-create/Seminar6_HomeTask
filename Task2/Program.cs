// ЗАДАТЬ ДВУМЕРНЫЙ МАССИВ СЛЕДУЮЩИМ ПРАВИЛОМ: Аmn = M+N

void FillArray(int[,] matr)
{
    for(int m=0; m < matr.GetLength(0); m++)
    { for (int n=0; n < matr.GetLength(1); n++)
        { 
            matr[m,n] = m + n;
        }
    }
}

void PrintArray(int[,] matr)
{
    for(int m=0; m < matr.GetLength(0); m++)
    { for (int n=0; n < matr.GetLength(1); n++)
        { 
            Console.Write($"{matr[m,n]}  ");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 3;

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
