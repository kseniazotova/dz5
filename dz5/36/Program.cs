﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19
int [] GetRandomArray (int size, int minValue, int maxValue)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
result[i] = new Random () . Next (minValue, maxValue + 1);
}
return result;
}
int sum (int[] array)
{
int count = 0;
{
for (int i = 0; i <array. Length; i+=2)
count+=array [i];
}
return count;
}
int [] arr = GetRandomArray (10, -10, 10);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum (arr)}");