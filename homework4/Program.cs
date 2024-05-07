//Задача 1
//Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.Write ("Введите букву q или любое целое число ");
    string inp = Console.ReadLine();

    if (inp == "q")
    {
        break;
    }

    int number;

    if (int.TryParse(inp, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum = sum + number % 10; 
            number = number / 10;
        }
        if (sum % 2 == 0)
        {break;}
    }

    else 
    {   
        Console.Write ("Неверный ввод. Введите букву q или любое целое число");
    }
}

//Задача 2
//Задайте массив заполненный случайными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int  [] CreateArray (int size)
{
    int [] createdArray = new int [size];
    for (int i = 0; i < createdArray.Length; i++)
    {
        createdArray [i] = new Random().Next (100, 999);
    }
    return createdArray;
}

void ShowArray (int [] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
Console.WriteLine();
}

int CountofEvenNum (int [] arrayforcount)
{
    int count =0;
    for (int i = 0; i < arrayforcount.Length; i++)
    {
        if (arrayforcount [i]  % 2 == 0)
            count++;
    }
    return count;
}

int size = 10;
int [] arrayTask2 = CreateArray(size);
ShowArray(arrayTask2);
Console.WriteLine($"Количество чётных чисел в массиве: {CountofEvenNum(arrayTask2)}");
*/

//Задача 3
//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

/*
int [] ToReverseArray (int [] array)
{
    int elem = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
        elem = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = elem;
    }
    return array;
}

void ShowArray (int [] arrayToShow)
{
    for (int i=0; i < arrayToShow.Length; i++)
        Console.Write($"{arrayToShow[i]} ");
Console.WriteLine();
}

int [] arrayTask3 = new int [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
Console.WriteLine("Изначальный массив:");
ShowArray(arrayTask3);
int [] newArray = ToReverseArray(arrayTask3);
Console.WriteLine("Перевернутый массив:");
ShowArray(newArray);
*/
