//Задайте значения M и N. Напишите программу, которая выведет все чётные 
//натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int InputInt(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

void EvenNaturalNumbers(int start, int finish)
{
    if (start % 2 != 0) start++;
    if (start > finish) return;
    System.Console.Write(start + " ");
    EvenNaturalNumbers(start + 2, finish); 
}

int start = InputInt("Введите начало интервала");
int finish = InputInt("Введите конец интервала");
EvenNaturalNumbers(start, finish);