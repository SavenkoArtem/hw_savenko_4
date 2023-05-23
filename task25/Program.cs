int Promt(string msg)
{    
    Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());    
    return num;
}


int NumberOfDegree(int A, int B)
{
    int result = Convert.ToInt32(Math.Pow(A, B));
    return result;
}


try
{
int A = Promt("Enter a nutural number:");
int B = Promt("Enter a degree:");
Console.WriteLine($"Result = {NumberOfDegree(A, B)}");
}
catch
{
    Console.WriteLine("You need enter a natural number!");
}