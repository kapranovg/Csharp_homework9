/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int InputInt(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

int m = InputInt("Введите число m");
int n = InputInt("Введите число n");
System.Console.WriteLine(AkkermanFunction(m, n));
