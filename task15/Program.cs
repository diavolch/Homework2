/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

string getDayOff(int dayNumber)
{
    string answer = "";
    if ( dayNumber == 6 || dayNumber == 7 )
    {
        answer = "Да";
    }
    else 
    {
        answer = "Нет";
    }
    return answer;
}

Console.Write("Введите цифру от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
string aboutDay = getDayOff(day);
Console.WriteLine(aboutDay);