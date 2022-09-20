/*
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int getThirdNumber(int someNumber)
{   
    int thirdNumber = 0;
    while ( someNumber > 999 )
    {
        someNumber = someNumber / 10;
    }
    if ( someNumber >= 100 &&  someNumber <= 1000 )
    {
        thirdNumber = someNumber % 10;
    }
    else
    {   
        Console.WriteLine("Третьей цифры нет");
        thirdNumber = -1;
    }
    return thirdNumber;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = getThirdNumber(number);
Console.WriteLine(result);