using Tyuiu.RadchenkoAV.Sprint1.Task5.V1.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Радченко А. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Создание решения к таску                                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнила: Радченко А. В. | РППб-25-1                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите координату x1: ");
var x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
var y = double.Parse(Console.ReadLine());
Console.WriteLine("" + x);
Console.WriteLine("" + y);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"*{ds.DistanceBetweenDots(x, y)}*");
Console.ReadLine();
