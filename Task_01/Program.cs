// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] CreateArray(int number)
{
int[] array = new int [number];
int count = 1;
for (int i=0; i<number; i++)
    {
    array[i] = EnterData($"Введите число {count}: ");
    count++;
    }
return array;
}

int CountPositiveNumbers(int[] arr)
{
int length = arr.Length;
int count = 0;
for (int i=0; i<length; i++)
    {
    if (arr[i] >0) count++;
    }
return count;
}

int quantityOfNumber = EnterData("Введите количество чисел для ввода: ");
int[] massive = CreateArray(quantityOfNumber);
int quantityPositiveNumbers = CountPositiveNumbers(massive);
Console.WriteLine($"[{String.Join(",",massive)}]->{quantityPositiveNumbers}");
