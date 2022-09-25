// Задача 228: Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
// 1 2 3 4 5 6 7-> 4
// 10 20 30 40 50 60 70 -> 40

// Создать массив
// Найти произведение всех элементов
// Найти среднее арифметическое


int size = new Random().Next(7, 7);
int[] array = new int[size];

int i = 0;
while (i < size)
{
    array[i] = new Random().Next(1, 1000);
    i++;
}
i = 0;
while (i < size)
{
    Console.Write(array[i] + " ");
    i++;
}
int sum = 0;
i = 0;
while (i < size)
{
    sum = sum + array[i];
    i++;
}
Console.WriteLine(sum);
int result = sum / size; 
Console.WriteLine(result);



// ВАРИАНТ ПРЕДЛОЖЕННЫЙ РЕВЬЮЕРОМ.

// Console.WriteLine("Введите планируемое количество чисел:");
// int count = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i < count; i++)
// {
// Console.WriteLine($"Введите {i + 1}-ое число:");
// int number = int.Parse(Console.ReadLine());
// sum = sum + number;
// }
// int average = sum / count;
// Console.WriteLine(average);