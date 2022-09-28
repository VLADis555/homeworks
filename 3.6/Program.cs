
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool IsPalindrom(int number) {
    string numberText = Convert.ToString(number);
    return numberText[0]==numberText[4] && numberText[1]==numberText[3];
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number " + number + " is "+(IsPalindrom(number) ? "" : "not ")+"palindrom");
*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
// Вывод строки и ввод числа
int ReadInt(string message) {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double GetLength3D (double[] pointA, double[] pointB) {
    return Math.Sqrt(
        Math.Pow(pointB[0] - pointA[0], 2) + 
        Math.Pow(pointB[1] - pointA[1], 2) +
        Math.Pow(pointB[2] - pointA[2], 2)
    );
}

int pointA_X = ReadInt("Point A coord X: ");
int pointA_Y = ReadInt("Point A coord Y: ");
int pointA_Z = ReadInt("Point A coord Z: ");
int pointB_X = ReadInt("Point B coord X: ");
int pointB_Y = ReadInt("Point B coord Y: ");
int pointB_Z = ReadInt("Point B coord Z: ");

double length = GetLength3D (new double[]{pointA_X, pointA_Y, pointA_Z}, new double[]{pointB_X, pointB_Y, pointB_Z});

Console.WriteLine("Distance between two given points is: "+length);
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Вывод строки и ввод числа
int ReadInt(string message) {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Input number: ");

Console.Write("all cubs of numbers from 1 to " + number + " are: ");
for (int i=1;i<=number;i++) {
    Console.Write((i==1?"":", ")+Math.Pow(i,3));
}
Console.WriteLine();