// 1. Описать метод(функицю), псевдослучайного числа от min до max.
// 2. Описать метод(функицю), создающую массив с указанным кол-вом элементов.
// 3. Описать метод(функицю), заполнения массива псевдослучайными числами.
// 4. Описать метод(функицю), распечатывания исходного массива.
// 5. Описать метод(функицю), нахождения количества четных чисел в массиве
// 6. Описать метод(функицю), финального решения.
// 
// 


// void - метод не возвращает результат. 

int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void Fill(int[] array)
{
    int size = array.Lenght;
    int i = 0;

    while (i < size)
    {
        array[i] = GetIntValue(1, 10);
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

void SearchEvenNumbers(int[] array)
{
    int count = 0;
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
        i++;
    }
return count;
}

void Final(int[] data, int count)
{
    int evenItems = new int[count];
    int position = 0;
    int i = 0;
    int size = data.Length;

    while (i < size)
    {
        if (data[i] % 2 == 0)
        {
        evenItems[position] = data[i];
        position += 1;
        }
        i += 1;
    }
return evenItems;
}


// int lenght = GetIntValue(10, 20);
// int[] col = CreateArray(lenght);
// Print(col);

int length = GetIntValue(10, 20);
int[] col = CreateArray(length);
Print(col);
Fill(col);
Print(col);
int count = SearchEvenNumbers(col);
int[] result = Final(col, count);
Print(result);