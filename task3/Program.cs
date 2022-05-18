// Найти количество чисел
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int index = 1;
while (number > 9)
{
    number = number / 10;
    index++;
}
Console.WriteLine($"Количество чисел {index}");

//Вариант 2 через строку-посчитать длину строки
//int number = int.Parse(Console.ReadLine());
//string c;
//c = number.Tostring();
//int c1 = c.Length;
//Console.WriteLine($"Количество чисел в числе {number} - {c1}");