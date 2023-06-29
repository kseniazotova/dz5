// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
Console.WriteLine("Введите количество элементов массива"); 
int size = Convert.ToInt32(Console.ReadLine()); 
int[] result = new int[size];
void mas(int size) 
{ 
    for (int i = 0; i < size; i++) 
    { result[i] = new Random().Next(99,999); 
    Console.Write(result[i] + " "); }
}
int kol(int[] randomArray) 
{ int kol = 0; 
for (int i = 0;
 i < randomArray.Length; i++) 
 { if (randomArray[i] % 2 == 0) 
 kol = kol + 1; } 
 return kol;
}
mas(size); 
Console.Write($"Количество чётных чисел в массиве: {kol(result)}");