// See https://aka.ms/new-console-template for more information
Console.WriteLine("What would you like to be your ending number?");
int endingNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= endingNumber; i++)
{
    Console.WriteLine(i);	
}

