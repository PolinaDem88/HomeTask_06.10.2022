/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

void GetNumber (int number)
{
    int result = number/10%10;
    if (number>99 && number<1000)
        Console.WriteLine($"{number} -> {result}");
    else 
        Console.WriteLine("Это число не трехзначное, введите трехзначное число");
}
GetNumber(5000);
