
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] FillMatr(int rows, int cols, int hight)
{
    int numb=10;
    int[,,] matrix = new int[rows, cols, hight];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < hight; k++)
            {
                 numb+=3;
                matrix[i, j, k] = numb;
            }
        }
    }
    return matrix;
}

void PrintMatr(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                System.Console.Write($"{matr[i, j, k]} ({i} {j} {k})  ");
            }
            System.Console.WriteLine();
        }
    }
}

int [,,] matrix= FillMatr(2,2,2);

PrintMatr(matrix);