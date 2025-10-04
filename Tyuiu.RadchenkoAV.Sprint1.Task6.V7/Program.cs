using Tyuiu.RadchenkoAV.Sprint1.Task6.V7.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Радченко А. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Создание решения к таску                                          *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнила: Радченко А. В. | РППб-25-1                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите x:");
var x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
var y = double.Parse(Console.ReadLine());
Console.WriteLine("" + x);
Console.WriteLine("" + y);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"*{ds.Calculate(x, y)}*");
Console.ReadLine();
