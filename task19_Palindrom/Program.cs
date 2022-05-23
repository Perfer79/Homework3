// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

//Первый вариант
// Console.WriteLine("Введите 5-значное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Number1 = (number / 10000);
// int Number5 = (number % 10);
// //Console.WriteLine(Number1+" "+Number5); на память
// int Number2 = (number / 1000);
// int Number4 = (number % 100);
// //Console.WriteLine(Number2+" "+Number4); на память
// if(Number1 == Number5 || Number2 == Number4)
// {
//     Console.WriteLine($"{number} -> да");
// }
// else
// {
//     Console.WriteLine($"{number} -> нет");
// }

// Второй вариант
Console.WriteLine("Введите палиндром ");
string number = Console.ReadLine();
bool Palin = true;

for (int i = 0; i < (number.Length - 1) / 2; i++)
{
    if (number[i] != number[number.Length - i - 1])
    Palin = false;
}
if (Palin)
{
    Console.WriteLine("Палиндром");
}
else 
{
    Console.WriteLine("Не палиндром");
}
