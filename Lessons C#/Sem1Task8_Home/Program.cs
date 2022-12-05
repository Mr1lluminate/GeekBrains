//==============================================================
// # 8 Напишите программу, которая на вход принимает число (N), 
//   а на выходе показывает все чётные числа от 1 до N.
//==============================================================

// My Option 
// string? inputLineN = Console.ReadLine();

// if (inputLineN != null)
// {
//     int inputNumberN = int.Parse(inputLineN);
//     if (inputNumberN % 2 == 0)
//     {
//         int startNubmer = (2);
//         while (startNubmer < inputNumberN)
//         {
//             if (startNubmer % 2 == 0)
//                 Console.Write(startNubmer + ", ");
//             startNubmer++;
//         }
//         Console.Write(inputNumberN);
//     }
//     else
//     {
//         int startNubmer = (2);
//         while (startNubmer < inputNumberN)
//         {
//             if (startNubmer % 2 == 0)
//                 Console.Write(startNubmer + ", ");
//             startNubmer++;
//         }
//     }
// }

// Educator Option
string? inputLineN = Console.ReadLine();
if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    int startNubmer = 2;
    while (startNubmer <= inputNumberN - 2)
    {
        Console.Write(startNubmer + ", ");
        startNubmer = startNubmer + 2;
    }
    Console.Write(startNubmer);
}