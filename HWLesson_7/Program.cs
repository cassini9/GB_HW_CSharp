// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandomArray( int m, int n, int min, int max)
// {
//     double[,] array = new double[m, n];


//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(min, max), 2);

//         }
//     }
//     return array;
// }

// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// double[,] myArray = CreateRandomArray(3, 4, -5, 5);

// ShowArray(myArray);



//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }

// int[,] myArray = CreateRandomArray(4, 3, 1, 20);


// void CheckArrayElenentByPosition(int m, int n, int[,] array)
// {
//     if (m < array.GetLength(0) && n < array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i == m && j == n)
//                 {
//                     Console.WriteLine("The array's element: " + array[i, j]);
//                     break;
//                 }
//             }
//         }
//     }
//     else {
//         Console.WriteLine("No elements with such a position exist");}
// }


// ShowArray(myArray);

// Console.WriteLine("Enter row position: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter column position: ");
// int column = Convert.ToInt32(Console.ReadLine());

// CheckArrayElenentByPosition(row, column, myArray);



//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце


int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

int[,] myArray = CreateRandomArray(3, 4, 1, 11);

ShowArray(myArray);

void MeanForColumns(int[,] array)
{
    double result = 0;
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
                sum = sum + array[i,j];
        }
        result = sum/array.GetLength(0);
        Console.WriteLine("Mean for the column is " + Math.Round(result, 2) + " correspondly");
        sum = 0;
    }
}


MeanForColumns(myArray);


