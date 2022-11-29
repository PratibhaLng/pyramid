int spc, length = 1, count, s = 0;

Console.WriteLine("Enter the number of rows");
count = Convert.ToInt32(Console.ReadLine());
spc = count - 1;

for (int i = 1; i < count; i++)
{

    for (s = 1; s < i; s++)
    {
        Console.Write(" ");

    }

    for (int r = 1; r <= (count * 2 - (2 * i - 1)); r++)
    {
        Console.Write("*");
    }

    Console.WriteLine("\n");
}

for (int i = 1; i <= count; i++)
{
    for (int r = 1; r <= spc; r++)
    {

        Console.Write(" ");

    }
    for (int c = 1; c <= length; c++)
    {
        Console.Write("*");


    }

    spc--;
    length = length + 2;
    Console.WriteLine("\n");
}
Console.ReadLine();






