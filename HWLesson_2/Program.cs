// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


void ShowNumber1() {
    
    Console.WriteLine("Enter 3 digits number:");
    int number = Convert.ToInt32(Console.ReadLine());

    number = number/10;
    number = number%10;

    Console.WriteLine("Second digit" + "->" + number);
    
}

ShowNumber1();


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int a){
    
    if(a/10 > 9){
        Console.WriteLine(a%10 + " third digit");
    }else{
        Console.WriteLine("no third digit exists");
    }
}

Console.WriteLine("Enter 1, 2 or 3 digits number:");
ThirdNumber(Convert.ToInt32(Console.ReadLine()));


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfTheWeek(int d){

    if (d < 6 && d > 0){
        Console.WriteLine("Today is working day!");
    }
    else if (d == 0 || d > 7){
        Console.WriteLine("The number does not represent a day of the week");
    }
    else {
        Console.WriteLine("Today is dayoff");
    }

}

Console.WriteLine("Enter a number representing day of the week from 1 to 7");
DayOfTheWeek(Convert.ToInt32(Console.ReadLine()));