//===================================================================
// # 5  Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N. 
//=================================================================== 

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 0)
    {
        int startNubmer = (-1) * inputNumberN;
        while (startNubmer < inputNumberN)
        {
            Console.Write(startNubmer + ", ");
            startNubmer = startNubmer + 1;
        }
        Console.Write(inputNumberN);
    }
}