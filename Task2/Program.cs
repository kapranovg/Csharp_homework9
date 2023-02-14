/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке 
от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30*/


int InputInt(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNaturalNumbers(int start, int finish)
{
    if (start > finish) return 0;
    return start + SumNaturalNumbers(start + 1, finish);
}

int start = InputInt("Введите начало интервала");
int finish = InputInt("Введите конец интервала");
System.Console.WriteLine(SumNaturalNumbers(start, finish));