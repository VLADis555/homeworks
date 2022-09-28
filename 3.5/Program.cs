
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int middleDigit = number / 10 - (number / 100) * 10;
Console.WriteLine("second digit of " + number + " is "+middleDigit);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length > 2) {
    Console.WriteLine("third digit of " + number + " is "+numberText[2]);
} else Console.WriteLine("number " + number + " has no third digit" );



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("day of week number " + number + " is "+(number>5 ? "day off" : "workday"));
