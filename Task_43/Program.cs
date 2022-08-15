// Задача 43: Напишите программу, 
//которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void TextTask()
{
    System.Console.WriteLine($"Необходимо ввести значения коэффициентов и действительных чисел, не равных 0, для двух прямых.");
}

double InputCoefficient()
{
    System.Console.Write("Введите с клавиатуры значение коэффициента: ");  
    double arg = Convert.ToDouble(Console.ReadLine()); 
    return arg;
}

double InputNumber()
{
    System.Console.Write("Введите с клавиатуры значение действительного числа: "); 
    double arg = Convert.ToDouble(Console.ReadLine()); 
    return arg;
}

TextTask();
System.Console.WriteLine();

double k1 = InputCoefficient();
double b1 = InputNumber();
double k2 = InputCoefficient();
double b2 = InputNumber();

System.Console.WriteLine();

if (k1 == k2)
{
    System.Console.WriteLine($"Прямые с заданными Вами данными, параллельны друг другу.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;

Console.WriteLine($"Координаты пересечения двух прямых: (x = {x.ToString("F02")} ; y = {y2.ToString("F02")})");
}