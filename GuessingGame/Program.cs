
Random randomNumGenerator = new Random();
int randomNumber = randomNumGenerator.Next(101); //This will get me a random integer between 0 and 100
int tries = 6; //Defines the max amount of tries

//Console.WriteLine(randomNumber);  //This displays that random integer
Console.WriteLine("What do you think the number is? You get 6 tries!");
int guessedNumber = Convert.ToInt32(Console.ReadLine()); //This gets an integer from the user

while (tries > 0)
   if (guessedNumber > randomNumber) {
   	 Console.WriteLine("Your guess is too high. Try again!");
   	 tries--;
   	 guessedNumber = Convert.ToInt32(Console.ReadLine()); //This gets an integer from the user after they have already tried
   }
   else if (guessedNumber < randomNumber) {
   	 Console.WriteLine("Your guess is too low. Try again!");
   	 tries--;
   	 guessedNumber = Convert.ToInt32(Console.ReadLine()); //This gets an integer from the user after they have already tried
   }
   else {
   	 Console.WriteLine("Your guess is PERFECT.");
   	 break;
   }