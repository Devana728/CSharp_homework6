// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}
int[] GeneraitArray(int length)

{
    int [] array = new int[length];
    int a = Prompt("Введите любое целое число :");
    int b = Prompt("Введите любое целое число :");
    int c = Prompt("Введите любое целое число :");
    int d = Prompt("Введите любое целое число :");
    int e = Prompt("Введите любое целое число :");
    int i = 0;
    while (i < array.Length)
    {
        array[0] = a;
        array[1] = b;
        array[2] = c;
        array[3] = d;
        array[4] = e;
        i++;
    }
    return array;
}

// вывод массива в строку
void printArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        System.Console.Write($"{array[count]}\t");
        count++;
    }
    System.Console.WriteLine();
}
int[] array1 = GeneraitArray(5);

printArray(array1);

int CountPositiveDigit(int[] array)
{
    int digit = 0;
    
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
        {
            
            digit = digit + 1;
        }
        
    return digit;
}
System.Console.WriteLine($"Количество чисел больше ноля {CountPositiveDigit(array1)}");
