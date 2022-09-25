Console.WriteLine("Введите планируемое количество чисел:");
int count = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < count; i++)
{
Console.WriteLine($"Введите {i + 1}-ое число:");
int number = int.Parse(Console.ReadLine());
sum = sum + number;
}
int average = sum / count;
Console.WriteLine(average);