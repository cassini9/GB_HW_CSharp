// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Clear();
// Console.WriteLine("Input first integer number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second integer number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2) {;
//     Console.WriteLine ("First number is greater than second");
// }
// else {
//     Console.WriteLine ("Second number is greater than first");
// }


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Input first integer number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third integer number");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3) {;
    Console.WriteLine ("First number is greater than the rest");
}
else if (num2 > num1 && num2 > num3){
    Console.WriteLine ("Second number is greater than the rest");
}
else {
    Console.WriteLine ("Third number is greater than the rest");
}



// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Input integer number");
int x = Convert.ToInt32(Console.ReadLine());

if ( x % 2 == 0 ) {
    Console.WriteLine ("The number is even");
}
else {
    Console.WriteLine("The number is odd");
}

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Input N:");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if (num > 1 && num % 2 == 0){
    current = num;
    num = num - 2;
}
else {
    current = num - 1;
}

while ( current > 1) {
    Console.Write(current + " ");
    current=current - 2;
}