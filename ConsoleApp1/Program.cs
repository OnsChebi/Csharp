//***************************** Roll the dice
// Random dice= new();
// int roll1=dice.Next(1,7);
// int roll2=dice.Next(1,7);
// int roll3=dice.Next(1,7);
// int total=roll1+roll2+roll3;

//  // Display the roll and total
// Console.WriteLine($" u rolled {roll1}, {roll2}, {roll3} and ur total is {total} " );
//  // Award a bonus for doubles or triples
// if(roll1==roll2 || roll1==roll3 || roll2==roll3)
// {
//     Console.WriteLine($"You rolled doubles or triples! You get a bonus! \n and ur total iiiiis {total+2}");
// }
//******************************Guess the Number game

 // Set up the game
 Console.WriteLine("  I'm thinking of a number between 1 and 20. \n You have 5 guesses. Good luck!");
 int secretNumber= new Random().Next(1,21);
 int maxGuesses=5;
 int i = 0;

while(i<maxGuesses){
    Console.WriteLine($"Guess #{i+1}: ");
    int guess=int.Parse(Console.ReadLine());
    
    if (guess == secretNumber)
    {
        Console.WriteLine($"Congratulations! You guessed the number from the {i+1}!");
        break;
    }
    else if (guess< secretNumber)
    {   
        Console.WriteLine("Too low! Try again.");
        
    }
    else
    {
        
        Console.WriteLine("Too high! Try again.");
        
    }
    i++;
    if (i == maxGuesses)
    {
        Console.WriteLine($"Sorry, you've used all your guesses. The number was {secretNumber}.");
    }
}
    