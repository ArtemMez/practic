// Задача № 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*

Console.Write("Привет! Введи трёхзначное число - ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра твоего числа - "+stringNumber[1]);

*/

// Задача № 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*

Console.Write("Привет! Введи любое число - ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра твоего числа - " + anyNumberText[2]);
}
else {
  Console.WriteLine("третьей цифры здесь нет");
}

*/

// Задача № 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

/*

Console.Write("Привет! Введи число, которое обозначает день недели и я скажу выходной это или нет - ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Это выходной день");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это вообще не день недели");
  }
  else Console.WriteLine("Этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);

*/