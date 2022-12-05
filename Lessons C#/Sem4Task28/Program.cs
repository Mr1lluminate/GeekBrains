//--------------------------------------------------------
//                        Задача 28
// Напишите программу, которая принимает на вход число N
//        и выдаёт произведение чисел от 1 до N.
//--------------------------------------------------------

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

// Метод вывода результата 
void PrintResult(string line)
{
    Console.WriteLine(line);
}

long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

int number = ReadData("Введите число: ");
long factorial = CalculateFactorial(number);
PrintResult("Факториал равен: " + factorial);