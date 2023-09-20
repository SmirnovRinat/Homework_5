/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
using System;
using System.Runtime.Intrinsics.Arm;

namespace Example36
{
    class exercise_36 { 

static void Main() { 

Console.Clear(); 

int sizeArray = 4;
int[] numbers = new int[sizeArray];
ArrayRandomNumbers(numbers);
PrintArray(numbers);

int sumNumbersEvenIndex = 0;

for (int i = 1; i < numbers.Length; i += 2)
{
    sumNumbersEvenIndex += numbers[i];
}
System.Console.Write("Сумма элементов на нечётных позициях: ");
System.Console.Write(sumNumbersEvenIndex);



void ArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
    System.Console.WriteLine($"Рандомное число массива: {array[i]}");
           }
   
}


}}}