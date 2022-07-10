//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// int[,] myArray = CreateRandomArray(3, 6, 1, 11);

// ShowArray(myArray);

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int t = j + 1; t < array.GetLength(1); t++)
//             {
//                 if (array[i, t] > array[i, j]){
//                     int temp = array[i,j];
//                     array[i,j] = array[i, t];
//                     array[i,t] = temp;

//                 }
//             }
//         }

//     }
// }

// SortArray(myArray);
// Console.WriteLine();
// ShowArray(myArray);

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

// int GetRowNumber(int[,] array)
// {
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minsum = minsum + array[0, i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];

//         }
//         if (minsum > sum)
//         {
//             minsum = sum;
//             row = i;
//         }

//     }
//     return row;

// }


// int[,] myArray = CreateRandomArray(3, 4, 1, 11);

// ShowArray(myArray);
// Console.WriteLine();
// Console.WriteLine("The lowest element's sum is in row " + GetRowNumber(myArray));
// Console.WriteLine();


//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

// int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 arrayC [i, j] += arrayA[i,k] * arrayB[k, j];
//             }
//         }
//     }
//     return arrayC;
// }


// int[,] myArray1 = CreateRandomArray(4, 4, 1, 11);
// int[,] myArray2 = CreateRandomArray(4, 4, 1, 11);


// ShowArray(myArray1);
// Console.WriteLine();
// ShowArray(myArray2);
// Console.WriteLine();
// ShowArray(GetMultiplicationMatrix(myArray1,myArray2));


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];

//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next (min, max + 1);
//                 if( FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result; 
// }

// bool FindElement(int[,,] array, int el )
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if(array[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false; 
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.WriteLine($"{array[i,j,k]} ({i},{j},{k})  ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }



// Console.Write("Введите размеры массива через пробел");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray (new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 10, 99);
// PrintArray(array);


//Заполните спирально массив 4 на 4.


// int[,] GetArray(int size)
// {
//     int[,] result = new int[size, size];
//     int i = 0;
//     int j = 0;
//     int rowE = size - 1;
//     int columnE = size - 1;
//     int rowS = 0;
//     int columnS = 0;
//     bool left = true;
//     bool top = true;
//     int count = 0;
//     while (count < size * size)
//     {
//         count++;
//         result[i, j] = count;
//         if (left && top)
//         {
//             rowS++;
//             top = true;
//             left = false;
//             i++;
//             continue;
//         }
//         else
//         {
//             j++;
//             continue;
//         }
        
//     }
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

// Console.Write("Enter matrix size  ");
// int s = int.Parse(Console.ReadLine());
// int[,] arr = GetArray(s);
// ShowArray(arr);


namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введите размерность массива");
            n = Convert.ToInt32(Console.ReadLine());
            var a = GetSpire(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static int[,] GetSpire(int n)
        {
            var result = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = rand.Next(n, n);
            for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
            {
                for (int j = padding; j < n - padding; j++)
                    result[padding, j] = currentChar;
                for (int j = padding; j < n - padding; j++)
                    result[n - padding - 1, j] = currentChar;
                for (int i = padding + 2; i < n - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (int i = padding + 1; i < n - padding - 1; i++)
                    result[i, n - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (n % 2 != 0 && result[0, 0] == 1)
                result[n / 2, n / 2] = 1;
            return result;
        }
    }
}