// Задать массив из 8 элементов и вывести его на экран

//Вариант 1

//Console.WriteLine("Введите 8 элементов ");
//int[] array = new int[8];
//for (int i = 1; i <= 8; i++)
//{
//    Console.Write($"Введите элемент номер {i}:\n");
//    array[i - 1] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine();
//PrintArray(array);
// Функция вывода массива на экран
//void PrintArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//}


//Вариант 2 через уже заданные данные

//int [] array = { 1, 8, 3, 5, 6, 9, 29, 67 };
//for (int i = 1; i < array.Length; i++)
//{
//    Console.WriteLine($"{array[i]}");
//}


//Вариант 3 через другой цикл
Console.Write("Введите размер массива ");
int arrSize = int.Parse(Console.ReadLine());
int[] array = new int[arrSize];
for (int i = 0; i < arrSize; i++)
{
    array[i] = new Random().Next(0, 100);
}
int count = 1;
foreach (int k in array)
{
    Console.WriteLine($"{count} элемент массива - {k}");
    count++;
}