//-----------------------------------------------------------
//                        Задача 13
// Напишите программу, которая выводит третью цифру заданного 
//        числа или сообщает, что третьей цифры нет.
//-----------------------------------------------------------

Console.WriteLine("Введите трёхзначное число: ");
string? inputLine = Console.ReadLine() ?? "";
if (inputLine.Length >= 3)
{
    int inputNumber = int.Parse(inputLine);
    char[] charArray = inputNumber.ToString().ToCharArray();
    Console.WriteLine(charArray[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}