const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "rock")
{
    playerMove = rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = scissors;
}
else
{
    Console.WriteLine("Invalid Input! Try again ...");
    return;
}
Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = rock; break;
    case 2:
        computerMove = paper; break;
    case 3:
        computerMove = scissors; break;
}
Console.WriteLine($"The computer chose {computerMove}");

if ((playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors) || (playerMove == scissors && computerMove == rock))
{
    Console.WriteLine("You loose!!!");
}
else if ((playerMove == paper && computerMove == rock) || (playerMove == scissors && computerMove == paper) || (playerMove == rock && computerMove == scissors))
{
    Console.WriteLine("Congratulations, you win!!!");
}
else
{
    Console.WriteLine("Draw");
}