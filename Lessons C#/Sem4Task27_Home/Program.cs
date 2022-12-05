//--------------------------------------------------------
//                        Задача 27
// Напишите программу, которая принимает на вход число и 
//              выдаёт сумму цифр в числе.
//--------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаме значение
    return number;
}

// Метод вывода результата 
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Вариант с длиной строки 
int CalculateDigitsString(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

// Вариант с Логарифмом
int CalculateDigits(int num)
{
    return (int)(Math.Log10(num) + 1);
}

// Метод, принимает число, возвращает сумму его цифр
int CalculateSumOfDigitsMath(int num)
{
    int sumOfDigits = 0;
    // На каждом шаге прибавляем к общей сумме остаток от деления числа на 10 и делим число на 10
    while (num > 0)
    {
        sumOfDigits += num % 10;
        num = num / 10;
    }
    return sumOfDigits;
}

int number = ReadData("Введите число: ");
int numberOfDigits = CalculateDigits(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);

numberOfDigits = CalculateDigitsString(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);

int SumNumber = CalculateSumOfDigitsMath(number);
PrintResult("Сумма чисел: " + SumNumber);