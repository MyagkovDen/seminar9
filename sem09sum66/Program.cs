/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();
int M = GetNumberFromUser("Введите натуральное число: ", "Ошибка ввода!");
int N = GetNumberFromUser("Введите натуральное число: ", "Ошибка ввода!");
int sum = GetSumNumbers(M, N);
Console.WriteLine($"M = {M}; N = {N} -> {sum}");

int GetSumNumbers(int number1, int number2)
{
    int sum;
if (number1 == number2) return number2;
else
{
sum = number1 + GetSumNumbers(number1+1, number2);
return sum;
}
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