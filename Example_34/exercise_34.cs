/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using System;
using System.Runtime.Intrinsics.Arm;

namespace Example34
{
    class exercise_34 { 

static void Main() { 

Console.Clear(); 

Console.WriteLine("Введите размер массива");
int sizeАrray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeАrray];
int count = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}


Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
}}}