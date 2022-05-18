// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

//Вариант 1

//int count = 0;
//while (count < n)
//{
//    int digit = count + 1;
//    Console.WriteLine($"Список квадратов чисел от 1 до {n} {digit * digit} ");
//    count++;
//}

//Вариант 2

//for (int count = 1; count < n; count++)
//{
//    Console.WriteLine($"Список квадратов чисел от 1 до {n} {count * count}");
//}

//Вариант 3 в виде таблицы

int i = 1;
int SqrN = 0;
while (i <= n)
{
    Console.Write($"  {i}  ");
    i++;
}
Console.WriteLine("");
i = 1;
while (i <= n)
{
    SqrN = i * i;
    Console.Write($"  {SqrN}  ");
    i++;
}