//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (B<1)
Console.Write("Число B должно быть натуральным\n");
else
{
while (B!=0)
{
c = c * A;
B = B-1;
}
Console.Write($"Число A в натуральной степени B равно {c}");
}