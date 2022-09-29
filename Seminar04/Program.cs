// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// ===

// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// ===

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве


// Задача 31 .
// 1. Создать массив.
// 2. Заполнить массив элементами от -9 до 9.
// 3. Распечатать массив.
// 4. Найти отрицательные элементы массива и их сумму.
// 5. Найти положительные элементы массива и их сумму.

int[] CreateArray(int size)
{
    return new int[size];
}


void Fill(int[] array)
{
    int size = array.Length;
    int i = 0;

    while (i < size)
    {
        array[i] = new Random().Next(-9, 10);
        i++;
    }
}


void Print(int[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}


// int SearchSumMinusNum(int sum1, int sum2)
// {
//     int sum1 = 0;
//     int sum2 = 0;
//     int size = array.Length;
//     int i = 0;
//     while (i < size)
//     {
//         if (array[i] < 0)
//         {
//             sum1 = sum1 + array[i];
//         }
//         else
//         {
//              sum2 = sum2 + array[i];
//         }
//         i++;
//     }
//     return;
// }


int SearchSumMinusNum(int[] array)
{
    int sum1 = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] < 0)
        {
            sum1 = sum1 + array[i];
        }
        i++;
    }
    return sum1;
}


int SearchSumPlusNum(int[] array)
{
    int sum2 = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        {
            sum2 = sum2 + array[i];
        }
        i++;
    }
    return sum2;
}

int[] mas = CreateArray(12);
Fill(mas);
Print(mas);
Console.WriteLine(SearchSumMinusNum(mas));
Console.WriteLine(SearchSumPlusNum(mas));