/*
Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int getSecondNumber(int number)
{
    int firstNumber = number / 10;
    int result = firstNumber % 10;
    return result;
}

int randomNumber = new Random().Next(100, 1000);
int secondNumber = getSecondNumber(randomNumber);
Console.WriteLine($"Вторая цифра числа {randomNumber} равна {secondNumber}");