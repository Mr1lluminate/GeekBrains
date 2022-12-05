//===================================================
// # 4 Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
//===================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    //=======================================================
    // # 1 Option
    //=======================================================
    // if (inputNumberA > inputNumberB)
    // {
    //     if (inputNumberA > inputNumberC)
    //     {
    //         Console.WriteLine("max: " + inputNumberA);
    //     }
    //     else
    //     {
    //         Console.WriteLine("max: " + inputNumberC);
    //     }
    // }
    // else
    // {
    //     if (inputNumberB > inputNumberC)
    //     {
    //         Console.WriteLine("max: " + inputNumberB);
    //     }
    //     else
    //     {
    //         Console.WriteLine("max: " + inputNumberC);
    //     }
    // }
    //=======================================================
    // # 2 Option
    //=======================================================
    // int resultNumber = Math.Max(inputNumberA, Math.Max(inputNumberB, inputNumberC));
    // Console.WriteLine("Max Number: " + resultNumber);
    //=======================================================
    // # 3 Option
    //=======================================================
    int NumberD = (inputNumberA > inputNumberB) ? inputNumberA : inputNumberB;
    int NumberE = (NumberD > inputNumberC) ? NumberD : inputNumberC;
    Console.WriteLine("Max Number " + NumberE);
}