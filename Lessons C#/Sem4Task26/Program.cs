//--------------------------------------------------------
//                        Задача 26
// Напишите программу, которая принимает на вход число и 
//              выдаёт количество цифр в числе.
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

int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int number = ReadData("Введите число: ");
int numberOfDigits = CalculateDigits(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);

numberOfDigits = CalculateDigitsString(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);

numberOfDigits = DigitCount(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);