﻿/*Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7*/

//функция получения массива

int[,] InitArray(int m, int n)
{
    int[,] array = new int[m,n];
    Random rnd = new Random();
    for(int i=0; i<m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(1, 10);
        }
    return array;
    }
}

(int, int) Min(int[,] array)
{
int min = array[0, 0];
int minRow = 0;
int minColumn = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
if(array[i,j] < min)
{
min = array[i, j];
minRow = i;
minColumn = j;
}
}
}
return (minrow, minColumn);
}

int[,] Delete (int[,] array, int minRow, int minColumn)
{
int countI = 0;
int countJ = 0;
int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (i != minRow && j != minColumn)
{
result[countI, countJ] = array[i, j];

countJ++;
}
}
countJ = 0;
if (i != minRow)
{
countI++;
}
}
return result;
}
        
void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}
int m = int.TryParse(Console.ReadLine());
int n = int.TryParse(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);
(int a, int b) = Min(array);
PrintArray(Delete(array, minRow , minColumn));
Console.ReadLine();