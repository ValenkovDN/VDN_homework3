// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

string RasTach()
{
Console.Write("Введите число, для составления таблицы ");
int a = Convert.ToInt32(Console.ReadLine());
int start = 1;
string res = "";

while(start <= a)
{
    res = res + start * start * start+", ";
    start = start + 1;
}
return res;
}

try
    {
        Console.WriteLine(RasTach());
    }
catch
    {
        Console.WriteLine("Надо было вводить целое число");
    }