// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 645 -> 5   78 -> третьей цифры нет

Console.Clear();

Console.WriteLine("В этой программе вы можете получить третью цифру любого числа, если она у него есть");
Console.WriteLine("\nВведите число: " );

int num = int.Parse(Console.ReadLine());

if (num > 99 && num <1000)

Console.WriteLine(num%10);

else if (num > 1000)

{
int rem = num/10;

while (rem > 999)

{
    rem = rem/10;
}

int fig = rem%10;
Console.WriteLine(fig);
}

else

Console.WriteLine("Третьей цифры нет");

