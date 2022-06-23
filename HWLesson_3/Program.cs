//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter five digits number:");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

int a1 = number % 10;
int a2 = number / 10 % 10;
int a3 = number / 100 % 10;
int a4 = number/1000 % 10;
int a5 = number /10000;
result = a1*10000 + a2*1000 + a3*100 + a4*10 + a5;

if (result == number) {
    Console.WriteLine("The number " + number + " is palindrome");
}
else{
    Console.WriteLine("The number " + number + " is not palindrome");
}


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistAB(int x1, int y1, int z1, int x2, int y2, int z2){
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

Console.WriteLine("Enter coordinates(x, y, z) of first point one by one");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinates(x, y, z) of second point one by one");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Segment length " + Math.Round(DistAB(x1, y1, z1, x2, y2, z2), 2));


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void listCubes(int n){
    int count = 1;
    while (count <= n ){
        Console.Write(Math.Pow((count), 3) + ", ");
        count++;
    }
}

Console.WriteLine("Enter the number:");
int num = Math.Abs(Convert.ToInt32((Console.ReadLine())));
listCubes(num);
