//---------------------------------------------------------------------
//                             Задача 14
//  Напишите программу, которая принимает на вход число и проверяет, 
//              кратно ли оно одновременно 7 и 23.
//---------------------------------------------------------------------

// My Option 

// int inputNumber = 0;
// bool numCheckA, numCheckB;

// ReadData();
// CalculateData();
// PrintData();

// // Получаем число от пользователя
// void ReadData()
// {
//     Console.WriteLine("Введите число: ");
//     string? inputLine = Console.ReadLine();

//     inputNumber = int.Parse(inputLine);
// }

// // Определяем кратность чисел
// void CalculateData()
// {
//     numCheckA = (inputNumber % 7 == 0);
//     numCheckB = (inputNumber % 23 == 0);
// }

// // Выводим данные вычисления
// void PrintData()
// {
//     if(numCheckA && numCheckB)
//     {
//         Console.WriteLine("Число кратное 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число некратное 7 и 23");
//     }
// }

//---------------------------------------------------------------------

// Option "Infinite loop"

// int number, resultA, resultB;

// int RequestNumber(string text = "Enter number", string exitCmd = "q")
// {
//     while (true)
//     {
//         Console.WriteLine(text + ": ");
//         string? inputLine = Console.ReadLine();

//         if (inputLine == null)
//         {
//             continue;
//         }
//         if (inputLine.ToLower() == exitCmd)
//         {
//             Environment.Exit(0);
//         }
//         if (int.TryParse(inputLine, out int number))
//         {
//             return number;
//         }
//     }
// }

// void ReadData()
// {
//     number = RequestNumber("Enter number");
// }

// void CalculateData()
// {
//     resultA = number % 7;
//     resultB = number % 23;
// }

// void PrintData()
// {
//     if (resultA == 0 && resultB == 0)
//     {
//         Console.WriteLine("Число кратное 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число некратное 7 и 23");
//     }
// }

// ReadData();
// CalculateData();
// PrintData();

//---------------------------------------------------------------------

// Short Version

string? inputLine = Console.ReadLine();
if (inputLine != null)
    Console.Write(((int.Parse(inputLine) % 7 == 0) && (int.Parse(inputLine) % 23 == 0)) ? ("Кратное") : ("Некратное"));

