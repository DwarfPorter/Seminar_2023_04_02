// Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

// Сумма чисел от 1 до number
int SumDigits(int number)
{
    int sum = 0;                        // Инициализируем переменную сумму
    for (int i = 1; i <= number; i++)   // Цикл - индекс i от 0 пока i меньше либо равно числу, шаг 1
    {
        sum = sum + i;                  // Вычисление суммы
    }
    return sum;                         // возращаем вычисленное значение
}

int SumDigitGauss(int number)
{
    return (1 + number) * number / 2;
}

int value;
value = ReadInt("Введите число");
int sum = SumDigits(value);
System.Console.WriteLine($"Сумма числа {value} равна {sum}");
int sumGauss = SumDigitGauss(value);
System.Console.WriteLine($"Сумма числа {value} равна {sumGauss}");