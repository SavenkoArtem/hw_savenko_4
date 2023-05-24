int Promt(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());    
    return num;
}

int[] CreateArray(int lenght)
{
    int[] newArray = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        newArray[i] = Promt("Enter array's element: ");
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
        }

        Console.Write(array[i]);

        if (i == (array.Length - 1))
        {
            Console.Write("]");
            Console.WriteLine();
        }
        else
        {
            Console.Write(",");
        }
    }
}


try
{
    int lenght = Promt("Enter a lengt's array: ");
    int[] newArray = CreateArray(lenght);
    PrintArray(newArray);
}
catch
{
    Console.WriteLine("You need enter a natural number!");
}
