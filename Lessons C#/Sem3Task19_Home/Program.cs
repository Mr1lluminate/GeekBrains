//----------------------------------------------------------
//                        Задача 19
// Напишите программу, которая принимает на вход пятизначное 
//     число и проверяет, является ли оно палиндромом.
//----------------------------------------------------------

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаме значение
    return number;
}

bool TestPolin(int numP)
{
    if ((numP / 10000 == numP % 10) && ((numP / 1000) % 10) == (numP / 10) % 10)
    return true;
    else
    return false;
}

void PrintData(bool line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите число:");
bool result = TestPolin(number);

PrintData(result);