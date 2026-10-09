// Roll the dice
Random dice= new();
int roll1=dice.Next(1,7);
int roll2=dice.Next(1,7);
int roll3=dice.Next(1,7);
int total=roll1+roll2+roll3;

 // Display the roll and total
Console.WriteLine($" u rolled {roll1}, {roll2}, {roll3} and ur total is {total} " );
 // Award a bonus for doubles or triples
if(roll1==roll2 || roll1==roll3 || roll2==roll3)
{
    Console.WriteLine($"You rolled doubles or triples! You get a bonus! \n and ur total iiiiis {total+2}");
}
