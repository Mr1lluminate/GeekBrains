//-------------------------------------------------------
//                     Задача 11
//    Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа 
//-------------------------------------------------------

void randomNumber()
{
    Console.WriteLine("My Option");
    int number = new Random().Next(100, 1000);

    Console.WriteLine(number);

    int ferstNum = number / 100;
    int secondNum = number % 10;
    int numberA = ferstNum * 10 + secondNum;

    Console.WriteLine(numberA);
}

void randomChar()
{
    Console.WriteLine("Option Char");
    int number = new Random().Next(100, 1000);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();

    Console.WriteLine("" + charArray[0] + charArray[2]);
}

randomNumber();
randomChar();