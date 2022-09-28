
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isEven = number % 2 == 0;


Console.WriteLine("number " + number + " is "+(isEven ? "" : "not ")+"even");
