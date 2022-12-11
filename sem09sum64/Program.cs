/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();

int N = GetNumberFromUser("Введите натуральное число: ", "Ошибка ввода!");
string range = OutputNumbers(N);
Console.WriteLine($"N = {N} -> {range}");


string OutputNumbers(int number)
{
    if (number == 1) return "1";
    return number + " " + OutputNumbers(number - 1);
}

int GetNumberFromUser(string text, string errorMessage)
{
    while (true)
    {
        Console.Write(text);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        else Console.WriteLine(errorMessage);
    }
}