// ПОКАЗАТЬ ДВУМЕРНЫЙ МАССИВ РАЗМЕРОМ MxN, ЗАПОЛНЕННЫЙ ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ


void FillArray(double[,] matr)
{
    for(int m=0; m < matr.GetLength(0); m++)
    { for (int n=0; n < matr.GetLength(1); n++)
        { 
            matr[m,n] = new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] matr)
{
    for(int m=0; m < matr.GetLength(0); m++)
    { for (int n=0; n < matr.GetLength(1); n++)
        { 
            Console.Write($"{matr[m,n]}  ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[5, 7];
FillArray(matrix);
PrintArray(matrix);
