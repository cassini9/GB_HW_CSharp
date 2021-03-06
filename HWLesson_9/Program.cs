// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// Console.Clear();
// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());

// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(m, n));

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

// int SumElements(int start, int end)
// {
//     int sum = 0;
//     if (start == end) return start;
//     else{
//         sum = start + SumElements(start + 1, end);
//         return sum;
//     }
// }

// Console.Clear();
// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());

// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine($"Sum of elements is  {SumElements(m,n)}");

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

int AckermannFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AckermannFunction(n - 1, 1);
    else
      return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}

Console.WriteLine($"Result of Ackermann's function is  {AckermannFunction(n,m)}");
