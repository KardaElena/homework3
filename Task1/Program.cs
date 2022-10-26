// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46

Console.Clear();

int a = new Random().Next(100,999);

Console.WriteLine($"{a}");

int b = (a/100)*10 + a%10;

Console.WriteLine($"{b}");

