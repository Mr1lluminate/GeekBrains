//----------------------Задача 47------------------------
//  Задайте двумерный массив размером m×n, заполненный 
//  случайными вещественными числами.     m = 3, n = 4.
//   0,5 7 -2 -0,2
//   1 -3,3 8 -9,9
//   8 7,8 -7,1 9
//-------------------------------------------------------

// Option #1

// // Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод, печатает двумерный массив вещественных чисел
// void Print2DArrayDouble(double[,] arr)
// {
//     // В циклах проходим по массиву, печатаем в консоль элементы, разделяя абзацем
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1) - 1; j++)
//         {
//             Console.Write($"{Math.Round(arr[i, j], 2)}; ");
//         }

//         Console.WriteLine($"{Math.Round(arr[i, arr.GetLength(1) - 1], 2)}");
//     }
// }

// // Метод генерации и заполнения массива вещественных чисел
// double[,] Fill2DArrayDouble(int rows, int cols, double numMin, double numMax)
// {
//     // Создаём массив
//     double[,] array2D = new double[rows, cols];

//     // Тест границ
//     if (numMin < numMax)
//     {
//         // Заполняем массив
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 array2D[i, j] = new Random().NextDouble() * (numMax - numMin) + numMin;
//             }
//         }
//     }
//     return array2D;
// }

// // Данные для генерации массива
// double numMin = 10;
// double numMax = 99;

// int inputRows = ReadData("Введите количество строк: ");
// int inputCols = ReadData("Введите количество столбцов: ");

// Console.WriteLine($"Случайный массив вещественных чисел {inputRows}x{inputCols}:");
// Print2DArrayDouble(Fill2DArrayDouble(inputRows, inputCols, numMin, numMax));

//--------------------------------------------------------------------------------------
// Option #2 Solution * : Another group's method of solution.

// Используем старые методы и их модфифируем под заданную задачу.
double[,] FillTwoDimDoubleArr(int countRow, int countColumn)
{
    double[,] outArray = new double[countRow, countColumn];
    System.Random numberSintezator = new System.Random();
    int i = 0;
    int j = 0;

    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            // Заполняем массив вещественными числами и округляем их до 2 знаков после запятой.
            outArray[i, j] = numberSintezator.Next(-11, 11) + numberSintezator.NextDouble();
            outArray[i, j] = Math.Round(outArray[i, j], 2);
            j++;
        }
        i++;
    }
    return outArray;
}

// Массив всех цветов для цветного вывода в консоли.
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan,
                                        ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow,
                                        ConsoleColor.Gray, ConsoleColor.DarkGray, ConsoleColor.Green,
                                        ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Yellow,
                                        ConsoleColor.White};

// Метод по выводу разноцветных цифр для любых двумерных массивов, так же будет работать и со строками и одномерными массивами
void PrintColorDimArray(double[,] inputArray)
{
    int i = 0;
    int j = 0;

    while (i < inputArray.GetLength(0))
    {

        j = 0;
        while (j < inputArray.GetLength(1))
        {
            // Разбиваем число на символы.
            char[] number = inputArray[i, j].ToString().ToCharArray();

            for (int k = 0; k < number.Length; k++)
            {
                // На каждый символ задаем свой цвет.
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(number[k]);
                Console.ResetColor();
            }
            Console.Write(" ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

double[,] twoDimArray = FillTwoDimDoubleArr(3, 4);
PrintColorDimArray(twoDimArray);