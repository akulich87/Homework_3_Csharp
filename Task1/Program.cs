﻿// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

if(num.Length > 4 && num.Length < 6)
{
  if(num[0] == num[4] && num[1] == num[3])
  {
    Console.Write("Число является палиндромом ");
  }
  else
  {
    Console.Write("Число не является палиндромом");
  }
}
else
  {
    Console.Write("Вы ввлели не пятизначное число");
  }
