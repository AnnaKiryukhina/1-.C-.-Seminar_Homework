// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number > 5 && number < 8) 
{
    System.Console.WriteLine(" да");
}
else
{
    System.Console.WriteLine(" нет");
}