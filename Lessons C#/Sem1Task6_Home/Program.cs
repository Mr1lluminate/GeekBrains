//==================================================================
// # 6 Напишите программу, которая на вход принимает число и выдаёт, 
//  является ли число чётным (делится ли оно на два без остатка).
//==================================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int checkNumber = inputNumber % 2;
    if (checkNumber == 0)
    {
        Console.WriteLine("Чётное");
    }
    else
    {
        Console.WriteLine("Нечётное");
    }
}