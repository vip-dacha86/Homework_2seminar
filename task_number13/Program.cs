﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5    // 78 -> третьей цифры нет    // 32679 -> 6

int Promt(string message)
{
    Console.Write(message);
    String value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number)
{
    while(number > 999)
   {
    number /= 10;
   }
return number % 10;
}
bool ValidateNumber(int number)
{
    if (number <1000)
{
    Console.WriteLine("Третьей цифры нет");
    return false;
}
return true;
}
int number =Promt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}
