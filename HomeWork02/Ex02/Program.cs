// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");

string number = Console.ReadLine();

if (number.Length > 2)

{
   Console.WriteLine($"третья цифра - {number[2]}"); 
}

else 

{
    Console.WriteLine("Третьей цифры нет");
}


// int ReadData(string line)
// {
//     Console.WriteLine(line);
//     int number = int.Parse(Console.ReadLine() ?? "");
//     return number;
// }

// char ThirdNumChar(string inputNumber)
// {
//     char[] simbols = inputNumber.ToCharArray();
//     return simbols[2];
// }

// int ThirdNumInt(int number)
// {
//     int lenNum = (int)Math.Log10(number);
//     int outNumber = (int)(number/Math.Pow(10,lenNum-2))%10;
//     return outNumber;
// }

// void PrintData(string prefix, string value)
// {
//     Console.WriteLine(prefix + value);
// }


// int number = ReadData("Введите число: ");
// if (number < 100)
// {
//     PrintData("Такой цифры нет", "");
// }
// else
// {
//     char thirdSimbol = ThirdNumChar(number.ToString());
//     PrintData("Третья цифра введеного числа: ", thirdSimbol.ToString());
// }