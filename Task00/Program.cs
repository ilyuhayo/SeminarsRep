// Напишите программу, 
// 1. которая на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например: 
// 4 -> 16
// -3 -> 9 
// -7 -> 49

Console.Write ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine ($"Квадрат числа {number} = {square}");

// double d = 4.566;
// string str = "Привет";
// bool b = false;


