using System.ComponentModel.Design;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        double result;
        char a; // следует давать значимые (передающие их смысл) имена переменным, например typeOfTransaction
        char again;
        link1: // использование якорей не приветствуется
        Console.WriteLine("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); // следовало добавить обработчик исключений (если не удалось преобразовать строку в число)
        Console.WriteLine("Введите способ вычислений(+,-,*,/): ");
        a = Convert.ToChar(Console.ReadLine()); // следовало добавить обработчик исключений (если не удалось преобразовать строку в число)
        Console.WriteLine("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); // следовало добавить обработчик исключений (если не удалось преобразовать строку в число)
        switch(a)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Ответ: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Ответ: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Ответ: {num1} * {num2} = {result}");
                break;
            case '/':
                result = num1 / num2; // нужна проверка деления на 0
                Console.WriteLine($"Ответ: {num1} / {num2} = {result}");
                break;
            default: 
                Console.WriteLine("Неизвестное значение");
                break;
        }
        Console.WriteLine("Желаете продолжить?(y/n)");
        again = Convert.ToChar(Console.ReadLine()); // следовало добавить обработчик исключений (если не удалось преобразовать строку в символ)
        if (again == 'y') goto link1; 
        else goto link2; // не используйте якеоря!!! говорила об этом на лекции
        link2:
        Console.WriteLine("Завершение программы.");
    }
}
