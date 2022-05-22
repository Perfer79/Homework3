// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

//Первый вариант
Console.WriteLine("Введите 5-значное число ");
int number = Convert.ToInt32(Console.ReadLine());
int Number1 = (number / 10000);
int Number5 = (number % 10);
//Console.WriteLine(Number1+" "+Number5);
int Number2 = (number / 1000);
int Number4 = (number % 100);
//Console.WriteLine(Number2+" "+Number4);
if(Number1 == Number5 || Number2 == Number4)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}


