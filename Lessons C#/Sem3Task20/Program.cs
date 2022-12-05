//---------------------------------------------------------------
//                         Задача 20
// Напишите программу, которая принимает на вход координаты двух 
//    точек и находит расстояние между ними в 2D пространстве
//---------------------------------------------------------------

// Option #1

// // Чтение данных из консоли
// int ReadData(string line)
// {
//     //Выводим сообщение
//     Console.WriteLine(line);
//     //Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаме значение
//     return number;
// }

// // Расстояние между двумя точками.
// double CalcData(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// }

// // Вывод данных
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// // Соберём данные.
// int x1 = ReadData("Введите X1 ");
// int y1 = ReadData("Введите Y1 ");
// int x2 = ReadData("Введите X2 ");
// int y2 = ReadData("Введите Y2 ");

// // Выведем результат.
// PrintResult(Math.Round(CalcData(x1, y1, x2, y2), 2).ToString());
//-----------------------------------------------------------------

// Option #2

// Чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаме значение
    return number;
}

// Расстояние между двумя точками.
double CalculateDistance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}

// Вывод данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Соберём данные.
int x1 = ReadData("Введите координату Х первой точки: ");
int y1 = ReadData("Введите координату Y первой точки: ");
int x2 = ReadData("Введите координату Х второй точки: ");
int y2 = ReadData("Введите координату Y второй точки: ");

double result = CalculateDistance(x1, y1, x2, y2);

// Выведем результат.
PrintResult("Расстояние между точками: " + Math.Round(result, 2));