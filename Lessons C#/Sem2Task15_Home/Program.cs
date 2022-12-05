//-------------------------------------------------------------------
//                            Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую 
//    день недели, и проверяет, является ли этот день выходным.
//-------------------------------------------------------------------

// Solution With The Class
//-------------------------------------------------------------------
// string? inputLine = Console.ReadLine();
// int numberDay = int.Parse(inputLine);
// if (numberDay == 6 || numberDay == 7)
// {
//     Console.WriteLine("Выходной день");
// }
// else
// {
//     Console.WriteLine("Будний день");
// }

// Use Dictionary
//-------------------------------------------------------------------
// void weekend()
// {
//     Console.WriteLine("Введите число обозначающий день недели");
//     string? inputLine = Console.ReadLine();
//     int numberDay = int.Parse(inputLine);
//     var weekDay = new Dictionary<int, string>()
//     {
//     {0, "Выходной день"},
//     {1, "Будний день"},
//     };
//     Console.WriteLine((numberDay == 6 || numberDay == 7) ? (weekDay[0]) : (weekDay[1]));
// }

//weekend();

//-------------------------------------------------------------------
// Educator Option

// Метод использующий коллекцию
void Option2()
{
    string? inputLineA = Console.ReadLine() ?? "";
    int inputNumberA = int.Parse(inputLineA);
    // Создаём коллекцию и заполняем её
    Dictionary<int, string> dayOfWeek = new Dictionary<int, string>()
    {
    {1,"Будний день"},
    {2,"Будний день"},
    {3,"Будний день"},
    {4,"Будний день"},
    {5,"Будний день"},
    {6,"Выходной день"},
    {7,"Выходной день"}
    };
    // Проверяем наличие ключа в коллекции и печатаем результат
    Console.WriteLine(dayOfWeek.ContainsKey(inputNumberA) ? ("Variant2: " + dayOfWeek[inputNumberA]) : ("Variant2: Введите правильное число!"));
}

Option2();