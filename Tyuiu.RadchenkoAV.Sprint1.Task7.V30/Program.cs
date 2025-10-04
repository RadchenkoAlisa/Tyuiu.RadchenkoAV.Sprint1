using Tyuiu.RadchenkoAV.Sprint1.Task7.V30.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Радченко А. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Создание решения к таску                                          *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнила: Радченко А. В. | РППб-25-1                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по      *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем.                     *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("Введите x:");
double x, y;
Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(ds.Calculate(x, y));


Console.ReadKey();

