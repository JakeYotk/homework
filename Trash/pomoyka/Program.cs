// Пример явного преобрахования одной переменной в другую. 


// Если выскакивает сообщение об ошибке неявного преобразования
// одного типа данных переменной в другой, можно применить явное преобразование.
// Для этого перед той переменной которую требуется преобразовать,
// необходимо в скобках указать тот тип даных который мы хотим присвоить
// этой переменной.


// int a;
// double r = 9;
// a = (int)r;
// Console.WriteLine("значение myByte: {0}", a);
// Console.WriteLine(r);



// // Таблица умножения.
// Console.Clear();
// Console.WriteLine("Введите первое число");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = int.Parse(Console.ReadLine());
// int mult;
// mult = a * b;
// Console.WriteLine(mult);


// // Переворот числа если оно записано в строке.

// Console.Clear();
// Console.WriteLine("Введите желаемое число");
// string number = Console.ReadLine();
// char[] numberarray = number.ToCharArray();
// Array.Reverse(numberarray);
// string output = new string(numberarray);
// Console.WriteLine(output);



// $ - интерполяция.  Интерполяция строк-это механизм объединения
//  двух или более строк вместе. В старых версиях C# мы использовали 
//  оператор “+” или строку. Метод Format использовался для 
//  конкатенации строк, но в C# 6.0 Microsoft предоставила
//   функцию под названием String Interpolation для 
//   конкатенации строк.







// ЗАДАЧА С СЕМИНАРА НУЖНО ДОРЕШАТЬ!!! ОБЯЗАТЕЛЬНО!!!

// Задать массив
// Заполнить массив элементами
// проверить условие
// финал



// int[] CreateArray(int size)
// {
//     return new int[size];
// }


// void Fill(int[] array)
// {
//     int size = array.Length;
//     int i = 0;

//     while (i < size)
//     {
//         array[i] = (1, 10);
//         i++;
//     }
// }


// void Print(int[] array)
// {
//     int i = 0;
//     int size = array.Length;
//     while (i < size)
//     {
//         Console.Write(array[i] + " ");
//         i++;
//     }
//     Console.WriteLine();
// }





using System.Linq;


string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (int.Parse(e[0]), int.Parse(e[1])))
                
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}


