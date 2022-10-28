﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Введите число N ->");
int number = Convert.ToInt32 (Console.ReadLine());

int [] Fibonachi (int num)
{
    
    int [] array = new int [num];
    array [0] = 0;
    array [1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array [i - 2];
    }
    return array;
}

void PrintArray(int[] array) //далем метод для вывода на печать массив через Void
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) // цикл
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); //выводим с запятой пока i меньше массива
        else Console.Write($"{array[i]} ");// иначе без запятой
    }
    Console.Write("]");
}


int [] arr = Fibonachi (number);
PrintArray (arr);