// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
string userInput = Console.ReadLine() ?? "";

int num = int.Parse(userInput);

if (num < 100 && num > -100) Console.WriteLine("Число не содержит третью цифру");
if (num > 99 || num < -99)
{
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine($"{userInput} -> {num}");
}