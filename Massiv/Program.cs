//Написать программу, которая из имеющегося массива строк формирует 
//массив из строк, длина которых меньше либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись
//исключительно массивами

string[] arr = { "4444", "37", "cat", "moscow", "123" };

void Mass(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
            Console.Write("; ");
    }
    Console.Write("] => ");
}

void NewMass(string[] arr)
{
    string[] NewArray = new string[arr.Length];
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write($"{NewArray[i] = arr[i]}");
            if (i < arr.Length - 1)
                Console.Write("; ");
        }
    }
    Console.Write("]");
}
Mass(arr);
NewMass(arr);