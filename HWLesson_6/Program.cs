// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

// int[] arr = new int[15];

// for (int i = 0; i < arr.Length; i++)
// {
//     if (i < 2)
//     {
//         arr[0] = 0;
//         arr[1] = 1;
//     }
//     else
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
//     Console.Write(arr[i] + " ");
// }


// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int decimalToBinary(int N)
{
    int B_Number = 0;
    int count = 0;
    while (N != 0)
    {
        int rem = N % 2;
        int c = (int)Math.Pow(10, count);
        B_Number += rem * c;
        N /= 2;

        count++;
    }

    return B_Number;
}


void Main()
{
    Console.WriteLine("Enter a number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The binary number representation is " + decimalToBinary(N));
}

Main();

