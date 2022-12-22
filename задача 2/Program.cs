// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
    else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}
int summ = 0;
int a = 1;
int GETRESULT( int m, int n)
{
    
    if(a < m)
    {
        a++;
        GETRESULT(m,n);
    }
    
    if(a >= m && a <= n)
    {
        summ = summ + a;
        a++;
        GETRESULT(m,n);

    }
    
    return summ;
}

int m = GetNumber("введите m");
int n = GetNumber("введите n");
int result = GETRESULT(m,n);
Console.WriteLine($"{result}");