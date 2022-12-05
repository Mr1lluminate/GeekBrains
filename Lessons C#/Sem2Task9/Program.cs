//--------------------------------------------------------
//                     Задача 9
// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа 
//--------------------------------------------------------

void defaultOption()
{
    Console.WriteLine("Option Default");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    int ferstDigit = number / 10;
    int secondDigit = number % 10;

    // Option 1 
    if (ferstDigit > secondDigit)
    {
        Console.WriteLine(ferstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void ternaryOption()
{
    Console.WriteLine("Option Ternary");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    int ferstDigit = number / 10;
    int secondDigit = number % 10;

    // Option 2 'ternary operator'
    Console.WriteLine((ferstDigit > secondDigit) ? ferstDigit : secondDigit);
}

void charOption()
{
    Console.WriteLine("Option Char");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    // Option 'char'
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

defaultOption();
ternaryOption();
charOption();
