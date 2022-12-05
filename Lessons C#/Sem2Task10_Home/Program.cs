//-----------------------------------------------------------
//                        Задача 10
// Напишите программу, которая принимает на вход трёхзначное 
//  число и на выходе показывает вторую цифру этого числа.
//-----------------------------------------------------------


Console.WriteLine("Введите трёхзначное число: ");
string? inputLine = Console.ReadLine() ?? "";
if (inputLine.Length == 3)
{
    int inputNumber = int.Parse(inputLine);
    char[] charArray = inputNumber.ToString().ToCharArray();
    Console.WriteLine(charArray[1]);
}
else
{
    Console.WriteLine("Число не трёх значное");
}