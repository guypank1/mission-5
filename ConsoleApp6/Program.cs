Console.WriteLine("*mission 1*");
Console.WriteLine();
Console.WriteLine("Hello, what is your name");
            string name = Console.ReadLine(); 
            Console.WriteLine("nice to meet you " + name + ", how many hours did you practice basketball this week?");
            int sad = int.Parse(Console.ReadLine());
if (sad < 30)
{
    Console.WriteLine("WARNING, you cannot play with only " + sad + " hours");
    int num = 30 - sad;
    Console.WriteLine(" you still have left " + num + " hours to train");
}

else if (sad == 30)
    {
    Console.WriteLine("Your hours are ok");
}
 else
{
    Console.WriteLine("Wow, thats a lot of effort");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("* mission 2 *");
Console.WriteLine();
Console.WriteLine("Hello " + name + ", type a number");
int num2 = int.Parse(Console.ReadLine());
if (num2 > 0 && num2 <= 1000)
{
    Console.WriteLine(num2 + " is a positive number");
}else if (num2 > 1000)
{
    Console.WriteLine(num2 + " is a Big number");
}
else if (num2 < 0 )
        {
    Console.WriteLine(num2 + " is a negetive number");
}
else if (num2 == 0)
{
    Console.WriteLine("Got 0");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("* mission 3 *");
Console.WriteLine();
Console.WriteLine("put a number");
int a = int.Parse(Console.ReadLine());
if (a > 80)
{
    Console.WriteLine(a + " is greater then 80");
}
else if (a == 80)
{
    Console.WriteLine("Number is 80");
}
else if (a == 79)
{
    Console.WriteLine(a + " is special");
}
else if(a < 79)
{
    Console.WriteLine(a + " is smaller than 80 but not special");
}