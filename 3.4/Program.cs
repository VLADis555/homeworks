
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("all even numbers from 1 to " + number + " are: ");
for (int i=2;i<=number;i+=2) {
    Console.Write((i==2?"":", ")+i);
}
Console.WriteLine();