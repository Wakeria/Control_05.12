// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длинна которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array = { "2", "sasuke", "come", "back", "to", "konoha", "!!!", ":-)" };
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write($" '{array[i]}', ");
    }
}
Console.Write("]");