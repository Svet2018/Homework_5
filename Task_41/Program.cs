// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, -567, 89, 223-> 3

void TextTask()
{
    System.Console.Write("Введите с клавиатуры несколько чисел, через запятую: ");
}


int SumPositiveNumbers(string numbers)
{
string[] spliNumbers = numbers.Split(',');
int sum = 0;
for (int i = 0; i < spliNumbers.Length; i++)
{
    int stringInNumbers = Convert.ToInt32(numbers.Split(',')[i]);
    if (stringInNumbers > 0) sum++;
}
 return sum;
}


void OutSum(int num)
{
    System.Console.WriteLine($"Положительных чисел введено - {num}");
}


TextTask();

string inputNumbers = Console.ReadLine();

OutSum(SumPositiveNumbers(inputNumbers));
