string[] Mass()
{
    string[] Array = { "12", "37", "cat", "moscow", "123" };
    Console.Write("[");

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}; ");
    }
    Console.Write("]");
    return Array;
}

Mass();

