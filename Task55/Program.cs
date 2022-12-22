/*Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.*/


//функция получения числа
//функция получения массива
//функция замены строк массива
//функция печати массива


//функция получения массива
int[,] GetArray(int m, int n)
{
int[,] array = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
array[i, j] = rnd.Next(1, 10);
}
}
return array;
}

//функция печати массива
Console.WriteLine("Наш массив:");
void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} ");
}
Console.WriteLine();
}
}

void reverse(int[,] arr)
{
int[,] arrayreverse = new int [arr.GetLength(1), arr.GetLength(0)];
for (int i = 0; i < arrayreverse.GetLength(0); i++)
{
for (int j = 0; j < arrayreverse.GetLength(1); j++)
{
arrayreverse[i, j] = arr[j, i];
}
}
Console.WriteLine("Перевернутый массив ниже:");
PrintArray(arrayreverse);
}

int[,] matrix = GetArray(2, 5);
PrintArray (matrix);
reverse(matrix);