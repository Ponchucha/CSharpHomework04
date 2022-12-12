/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void PrintArray (int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write ($"{array[i]}, ");
    }

    Console.Write($"{array[array.Length - 1]}]");
}

int[] GetArrayFromConsole ()
{
    int arrayLength = 8;
    int[] array = new int [arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine("Введите элемент массива");
        bool isItCorrect = false;
        int number = 0;
        while (!isItCorrect)
        {
            if (int.TryParse(Console.ReadLine(),out number))
            {
                isItCorrect = true;
            }
            else 
                Console.WriteLine ("Введённое не имеет смысла. Всё тлен. Но Вы попробуйте ввести число");  
        }
        array[i] = number;
    }
return array;
}

int[] arr = GetArrayFromConsole();
PrintArray(arr);