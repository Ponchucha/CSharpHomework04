/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    bool IsNumberCorrect = false;
    int result = 0;

    while (!IsNumberCorrect)
    {
        if (int.TryParse(Console.ReadLine(), out result))

            IsNumberCorrect = true;
        else
            Console.WriteLine("Опять Вы что-то не то ввели. Будем тут стоять, пока не введёте число.");

    }
return result;
}

int GetDigitSum(int number)
{
    int sum = 0;
    number = Math.Abs(number);

    while (number > 0)
    {
        sum = sum + number%10;
        number = number / 10;
    }
    return sum;
}

int number = GetNumberFromConsole("Введите число");
int sum = GetDigitSum (number);
Console.WriteLine($"Сумма цифр числа {number} равна {sum}");