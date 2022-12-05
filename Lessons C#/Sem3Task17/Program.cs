//---------------------------------------------------------
//                        Задача 17
// Напишите программу, является ли число квадратом другого
//---------------------------------------------------------

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

int QuterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

    return -1;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Введите координату X:");
int y = ReadData("Введите координату Y:");

int res = QuterTest(x, y);

PrintResult("Точка находится в четверти №: " + res);