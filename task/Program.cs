
string[] InputArray()
{
    Console.Write("Введите размер массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] result = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i}-й элемент: ");
        result[i] = Convert.ToString(Console.ReadLine())!;
    }
    return result;

}
string[] ArrayItemCheckLength(string[] array, int length)
{
    string[] result = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3 )
        {
            result[j] = array[i];
            j += 1;
        }
    }
    Array.Resize<string>(ref result, j);
    return result;

}
void PrintArray(string[] array)
{
   Console.WriteLine($"[{string.Join(",",array)}]");
}

int checkLength = 3;
string[] array = InputArray();
string[] result = ArrayItemCheckLength(array, checkLength);
PrintArray(result);