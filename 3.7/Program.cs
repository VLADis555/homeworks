
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// Вывод строки и ввод числа
int ReadInt(string message) {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int number, int power) {
    var result = number;
    for (int i=2;i<=power;i++) {
        result *= number;
    }
    return result;
}

int number = ReadInt("Input number: ");
int power = ReadInt("Input power: ");

int result = Pow(number, power);
Console.WriteLine("Number "+number+" to the power of "+power+" is "+result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Вывод строки и ввод числа
int ReadInt(string message) {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetDigitsSum(int number) {
    string numberText = Convert.ToString(number);
    int result = 0;
    for (int i=0;i<numberText.Length;i++) {
        Console.WriteLine(Int32.Parse(Convert.ToString(numberText[i])));
        result += Int32.Parse(Convert.ToString(numberText[i]));
    }
    return result;
}

int number = ReadInt("Input number: ");

int digitsSum = GetDigitsSum(number);
Console.WriteLine("Digits sum of number "+number+" is "+digitsSum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetRandomArray(int size) {
    int[] array = new int[size];
    for (var i=0;i<size;i++) {
        array[i] = new Random().Next(0,10);
    }
    return array;
}

void PrintArray(int[] array) {
    Console.Write("Array: [");
    for (var i=0;i<array.Length;i++) {
        Console.Write((i==0?"":", ")+array[i]);
    }
    Console.WriteLine("]");
}

int[] array = GetRandomArray(8);
PrintArray(array);
