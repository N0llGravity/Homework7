// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int[,] Create2dAray(int rows, int colums)
{
    int[,] array2d = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < rows; j++)
            array2d[i,j] = new Random(). Next(-100,100);

    return array2d;
}

void Show2dArray(int[,] array2d)
{
    for(int i = 0; i < array2d.GetLength(0); i++)
        {
            for(int j = 0; j < array2d.GetLength(1); j++)
            {
                Console.Write (array2d[i,j] + "\t");
            }
            Console.WriteLine();  
        }
}

Console.WriteLine("input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of colums ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array2d = Create2dAray(rows, colums);
Show2dArray(array2d);
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
