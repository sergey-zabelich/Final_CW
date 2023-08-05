string[] array_1 = new string[4] { "Hello", "2", "world", ";)" };
string[] array_2 = new string[array_1.Length];
void SecArr(string[] array_1, string[] array_2)
{
    int count = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
        if (array_1[i].Length <= 3)
        {
            array_2[count] = array_1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecArr(array_1, array_2);
PrintArray(array_2);
