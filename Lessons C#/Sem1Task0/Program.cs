//===========================================================
// # 0 Напишите программу, которая на вход принимает число и 
// выдаёт его в квадрат (число умноженное на само себя).
//===========================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    // int outNubmer = inputNumber * inputNumber;
    int outNubmer = (int)Math.Pow(inputNumber, 2);

    Console.WriteLine(outNubmer);
}