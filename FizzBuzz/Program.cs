﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("What would you like to be your ending number?");
int endingNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= endingNumber; i++)
{
	if (i % 3 == 0 && i % 5 == 0) {
   Console.WriteLine("fizzbuzz"); 
   }
   else if (i % 5 == 0) {
   	Console.WriteLine("buzz"); 
   }
   else if (i % 3 == 0) {
   	Console.WriteLine("fizz");
   }

   else {
    Console.WriteLine(i);	
  }
}
