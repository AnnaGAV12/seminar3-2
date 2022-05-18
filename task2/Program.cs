// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= a; i++)
//{
//    sum = sum + i;
//}

// Через арифметическую прогрессию
int sum=a*(a+1)/2;
Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");