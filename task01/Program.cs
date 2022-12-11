/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    bool isNumberCorrect = false;
    int result = 0;
    while (!isNumberCorrect)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isNumberCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. А мы просили число. Дайте нам число. Чтобы это было число, а не как сейчас.");
        }
    }
return result;
}
void PrintPowerOfNumber (int number, int power)
{
    Console.WriteLine($"Число {number}, возведённое в степень {power}, даёт в результате {Math.Pow(number,power)}") ;
}

int number = GetNumberFromConsole("Введите натуральнное число");
int power = GetNumberFromConsole("И ещё одно");

PrintPowerOfNumber(number, power);