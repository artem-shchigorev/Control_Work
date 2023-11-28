string EnterParameters(string message)
{
    System.Console.WriteLine();
    System.Console.WriteLine(message);
    System.Console.WriteLine();
    string? parameter = Convert.ToString(Console.ReadLine());
    return parameter;
}
string[] CreateInitialArray()
{
    bool check = false;
    int size = 0;
    while (check == false)
    {
        System.Console.WriteLine("Введите желаемое количество строк: ");
        size = Convert.ToInt32(System.Console.ReadLine());
        if (size > 0) check = true;
        else System.Console.WriteLine("Введено некорректное значение!");
    }
    string[] initialArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        initialArray[i] = EnterParameters($"Введите {i + 1}-ю строку: ");
    }
    return initialArray;
}
string[] ArrayConversion(string[] array)
{
    string[] intermediateArray = new string [array.Length];
    int cell = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            intermediateArray[cell] = array[i];
            cell++;
        }
    }
    string[] conversionArray = new string[cell];
    for (int i = 0; i < cell; i++)
    {
        conversionArray[i] = intermediateArray[i];
    }
    return conversionArray;
}
void PrintArray(string[] array)
{
    Console.Write("Преобразованный массив --> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(ArrayConversion(CreateInitialArray()));
