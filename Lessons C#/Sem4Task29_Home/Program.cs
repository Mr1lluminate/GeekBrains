//-------------------------------------------------
//                    Задача 29
// Напишите программу, которая задаёт массив из 8 
//          элементов и выводит их на экран.
//-------------------------------------------------

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

int[] GenArray(int arrLen, int Start, int Stop)
{
    Random rnd = new Random();
    int[] outArr = new int[arrLen];
    for (int i = 0; i < arrLen; i++)
    {
        outArr[i] = rnd.Next(Start, Stop);
    }
    return outArr;
}

// Метод вывода результата 
void PrintData(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int number = ReadData("Введите число ");
int[] res = GenArray(number, 0, 100);
PrintData(res);