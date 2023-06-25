// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// ==========================НАЧАЛО==========================
System.Console.WriteLine("Число A");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число B");
int B = Convert.ToInt32(Console.ReadLine());
int product = 1;
for (int i = 0; i < B;)
{
    product = product * A;
    i = i + 1;
    System.Console.WriteLine(product);
}
// ==========================КОНЕЦ==========================

