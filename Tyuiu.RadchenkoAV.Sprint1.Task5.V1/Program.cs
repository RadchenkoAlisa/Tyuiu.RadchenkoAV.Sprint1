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

Console.WriteLine("Введите X1:");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y1:");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите X2:");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y2:");
double y2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
Console.WriteLine(res);
Console.ReadLine();
