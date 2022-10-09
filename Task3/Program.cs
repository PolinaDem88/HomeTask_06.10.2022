/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
    void GetNumber (int number)
   {
       if (number>=1 && number<=5)
        Console.WriteLine($"{number} -> нет");
    else if (number>=6 && number<=7)
        Console.WriteLine($"{number} -> да");
    else
         Console.WriteLine("Вы ввели неверный день недели");
    }
GetNumber(8);
