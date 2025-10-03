using Tyuiu.RadchenkoAV.Sprint1.Task2.V25.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Радченко А. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Создание решения к таску                                          *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнила: Радченко А. В. | РППб-25-1                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x;

Console.WriteLine("Введите значение x:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"*{ds.ConvertRadsToDegrees(x)}*");
Console.ReadLine();