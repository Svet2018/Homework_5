// Задача 43: Напишите программу, 
//которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void TextTask()
{
    System.Console.WriteLine($"Чтобы определить точку пересечения двух прямых необходимо ввести значения b1, k1 и значения b2, k2");
}

int InputCoefficient()
{
    System.Console.Write("Введите с клавиатуры значение коэффициента: "); 
    int arg = Convert.ToInt32(Console.ReadLine()); 
    return arg;
}

int InputNumber()
{
    System.Console.Write("Введите с клавиатуры значение числа: "); 
    int arg = Convert.ToInt32(Console.ReadLine()); 
    return arg;
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}");
        }
        System.Console.WriteLine();
    }
}

/*
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;

double [,] myArray= new double [2,2];
for (int i = 0; i < 2; i++)
{ 
    double k = InputCoefficient();
    double b = InputNumber();     
}


*/
// Объявляем двумерный массив
int[,] myArr = new int[2, 2];
int k = InputCoefficient();
int b = InputNumber(); 
// Инициализируем данный массив
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
       //myArr[i, j ] = k;
       myArr[i, j] = b;
       Console.Write("{0}\t", myArr[i, j]);
    }
    Console.WriteLine();
}


/*
double [] GetX(int arg1, int arg2, int arg3, int arg4)
{
    double x = (arg4-arg2)/(arg1-arg3);
    double y = x * arg1 + arg2;
    double [] xy = new double[] {x , y};
    //if (arg1 != arg3) 
    return xy;    
}
TextTask();

InputCoefficient();
InputNumber();

InputCoefficient();
InputNumber();

GetX(InputCoefficient(), InputNumber(), InputCoefficient(), InputNumber());
*/