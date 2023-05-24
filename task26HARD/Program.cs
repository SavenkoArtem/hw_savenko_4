int CountNumbers(decimal num)
{
    int count = 0;
    int part1 = Convert.ToInt32(num);
    decimal part2 = num - part1;

    if (part1 == 0)
    {
        count++;
    }
    while (part1 > 0)
    {
        count += 1;
        part1 /= 10;        
    }

    while (part2 % 1 != 0)
    {
        part2 *= 10;
        count += 1;
    }

    return count;
}



Console.WriteLine("Enter a natural number");
try
{
    decimal num = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine($"Count numbers in {num} equal {CountNumbers(num)}");    
}
catch
{
    Console.WriteLine("You need enter a natural number!");
}