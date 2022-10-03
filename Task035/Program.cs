// Задача 35
// Задайте одномерный массив из 123 случайных чисел
// Найти кол-во элементов массива, значения которых
// лежат в отрезке [10, 99].

/// Сощдать массив
/// Заполнить массив
/// печать массива
/// финал


//1.
int[] Create(int len)
{
    return new int[len];
}

//2.
void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++);
}


//3.
string Print(int[] array)
{ 
    return "[" + String.Join(',', array) + "]";
}

//4. 
// int Search(int[] array)
// {
//     int size = array.Length;
//     int count = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if ( array[i] >= 10 && array[i] <= 99);
//     }
    
// }