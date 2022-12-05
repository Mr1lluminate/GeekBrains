//----------------------------------------------------------
//                         Задача 22
// Напишите программу, которая принимает на вход число N и 
//       выдаёт таблицу квадратов чисел от 1 до N
//----------------------------------------------------------

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

string LineNumbers(int numberN, int pow) // Добавили Pow для сокращения кода
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN, pow);
    return outLine;
}

// string LineSqer(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i * i + "\t";
//         ++i;
//     }
//     outLine = outLine + numberN * numberN;
//     return outLine;
// }

// Вывод данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N:");
string lineTop = LineNumbers(num, 1); // Было LineNumbers(num);
string lineDown = LineNumbers(num, 2); // Было LineSqer(num);

// Было
// PrintResult(lineTop);
// PrintResult(lineDown);

// Стало
PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));