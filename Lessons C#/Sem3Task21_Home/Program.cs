//--------------------------------------------------------------
//                        Задача 21
//   Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
//--------------------------------------------------------------


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
double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
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
int z1 = ReadData("Введите координату Z первой точки: ");
int x2 = ReadData("Введите координату Х второй точки: ");
int y2 = ReadData("Введите координату Y второй точки: ");
int z2 = ReadData("Введите координату Z второй точки: ");

double result = CalculateDistance(x1, y1, z1, x2, y2, z2);

// Выведем результат.
PrintResult("Расстояние между точками: " + Math.Round(result, 2));