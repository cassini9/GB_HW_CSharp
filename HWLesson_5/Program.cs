// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }

// }

// int[] MyArray = RandomArray(10);
// ShowArray(MyArray);

// void EvenNumberInArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;
//     }
//     Console.WriteLine(" Even number count is " + count);
// }

// EvenNumberInArray(MyArray);



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 20);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }

// }

// int[] MyArray = RandomArray(6);
// ShowArray(MyArray);

// void SumOddPositionsInArray(int[] array)
// {
//     int result = 0;

//     for (int i = 1; i < array.Length; i = i + 2)
//     {
//         result = result + array[i];
//     }
//     Console.WriteLine("The sum of odd element's position is " + result);

// }

// SumOddPositionsInArray(MyArray);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

int[] MyArray = RandomArray(6);
ShowArray(MyArray);

void MaxMinDifference(int[] array)
{
    int max = 0;
    int min = array[0];
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min){
            continue;
        }
        else{
            min = array[i];
        }
    }

    Console.WriteLine("MAX number: " + max + "  MIN number: " + min);
    result = max - min;
    Console.WriteLine("The difference between max and min is " + result);
}

MaxMinDifference(MyArray);

