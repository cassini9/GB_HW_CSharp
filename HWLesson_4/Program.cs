// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double PowerAB(int a, int b) {
    return Math.Pow((a), b);
}

Console.WriteLine("Enter two numbers one by one:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Result is " + PowerAB(a, b));

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int num){

    int sum = 0;

    for (int i = 0; i <= sum; i++){
        
            sum = sum + num%10;
            num = num/10;
        
    }
    return sum;
}

Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The result of digit's sum in the number is " + SumNum(number));


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] RandomArray(int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void ShowArray ( int[] array){

    for (int i =0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }

}

int[] EightElementsArray = RandomArray(8);
ShowArray(EightElementsArray);
