//------------------------------------------------------------------------------
//                                Задача 12
//    Напишите программу, которая будет принимать на вход два числа и выводить, 
//  является ли второе число кратным первому если второе число некратно первому, 
//               то программа выводит остаток от деления.
//------------------------------------------------------------------------------

// void multiple()
// {
//     Console.WriteLine("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.WriteLine("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     if (inputLineA != null && inputLineB != null)
//     {
//         int numberA = int.Parse(inputLineA);
//         int numberB = int.Parse(inputLineB);

//         bool check = (numberB % numberA == 0);

//         if (check)
//         {
//             Console.WriteLine("Число: " + numberB + " кратно: " + numberA);
//         }
//         else
//         {
//             Console.WriteLine("Не кратно. Осток от деления: " + numberB % numberA);
//         }
//     }
// }

// void multipleChar()
// {
//     Console.WriteLine("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.WriteLine("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     if (inputLineA != null && inputLineB != null)
//     {
//         int inputNumberA = int.Parse(inputLineA);
//         int inputNumberB = int.Parse(inputLineB);

//         Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления " + inputNumberB % inputNumberA));
//     }
// }

// multiple();
// multipleChar();

//------------------------------------------------------------------------------

// Для методов хорошим тоном писать комментарии: о его функционале и тд.

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
ConculateData();
PrintData();

// Получаем два числа от пользователя
void ReadData()
{
    Console.WriteLine("Введите первое число: ");
    string? inputLineA = Console.ReadLine() ?? "";
    Console.WriteLine("Введите второе число: ");
    string? inputLineB = Console.ReadLine() ?? "";

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}

// Определяем кратность чисел
void ConculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

// Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратное первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления " + inputNumberB % inputNumberA);
    }
}