// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с
//  клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arr1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите элемент массива:");
    arr1[i]= Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine($"Введенный массив: [{string.Join(",", arr1)}]");
int count = 0;
int maxSymbols = 3;

for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= maxSymbols)
    {
        count++;
    }
}
Console.WriteLine();

Console.Write("Полученный массив: [");
string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= maxSymbols)
    {
        arr2[j] = arr1[i];
        Console.Write(arr2[j] + ",");
        j++;
    }
}

Console.Write("]");
