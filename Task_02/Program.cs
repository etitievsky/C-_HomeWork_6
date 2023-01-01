// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ->({x}; {y})");
}

double b1 = EnterData("Введите переменную b1: ");
double k1 = EnterData("Введите переменную k1: ");
double b2 = EnterData("Введите переменную b2: ");
double k2 = EnterData("Введите переменную k2: ");
IntersectionPoint(b1, k1, b2, k2);