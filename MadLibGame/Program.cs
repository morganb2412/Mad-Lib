//Console.BackgroundColor = ConsoleColor.Blue;
StepZero: //Name sections of my code. 
Console.WriteLine("Welcome to MAD LIBS GAME!");
Step1:
Console.WriteLine("Are you ready to start? Enter Y for \"yes\", N for \"No\" and W for \"WAIT FOR ME\" ");

string startGame = Console.ReadLine();
string startGames = startGame.ToUpper();
//Introducing a switch statement. 
switch (startGames)
{
    case "Y":
        Console.WriteLine("Great lets start!");
        goto Start; //using the goto function to jump to certian parts of the program. 
        break;

    case "N":
        Console.WriteLine("Ok we can start again later");
        goto Step1;
        break;
    case "W":
        Console.WriteLine("Ok let me know when you are ready by entering \"ready\".");
        string readyGo = Console.ReadLine();
        string readyGo2 = readyGo.ToLower();
            if (readyGo2 == "ready")
        {
            goto Start;
        }
        else
        {
            Console.WriteLine("Ok you are not ready I will start the game over"); ;
            goto Step1;
        }

        break;

    default:
        Console.WriteLine("Sorry I did not get that let's try again!");
        goto Step1;
        break;

}

Start:
Console.WriteLine("My name is Mast of libs what is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Welcome {userName}!");

Middle:
Console.WriteLine($"Ok {userName}, enter in your first adjective: ");
string adjOne = Console.ReadLine();

Console.WriteLine("Great thank you! \n Now give me a noun");

string nounTwo = Console.ReadLine();

Console.WriteLine("Give me one city: ");
string city = Console.ReadLine();

Console.WriteLine("Give me a number between 1 and 10 :");
string playerNum = Console.ReadLine();

double playerNum2 = Convert.ToDouble(playerNum);

MiddleTwo:
Console.WriteLine("Ok give me one more noun: ");
string nounOne = Console.ReadLine();

Console.WriteLine("What is the last thing you ate ?: ");
string food = Console.ReadLine();

Console.WriteLine("What color shirt did you wear today? ");

string color = Console.ReadLine();

EndofStory:
string begStory = $" In the amazing but weird city called ({city}) there was {playerNum2} {nounOne} in the middle of the street where a group of kids were playing. ";
string secondPart = $" The kids all gathered around the {nounOne}. \n One kid said \"Omg that is a {adjOne} {nounOne}.\"";
string thirdPart = $" As the one kid attempted to pick up all of {nounOne}. The {nounOne} started to turn {color}. All of the kids took off running and one kid ran into {nounTwo}";
string fourthPart = $" Once all of the kids made back to the tree house, they all were super hungry and ordered {food}";
//Concate all of the strings together. 
string storyTogether = begStory + secondPart + thirdPart + fourthPart;

Console.WriteLine("Here is your story: ");
Console.WriteLine(storyTogether);

Console.WriteLine($"{userName} would you like to play again? Enter \"YES\" or \"NO\" ");

string playAgain = Console.ReadLine();
playAgain.ToUpper();
//nested if else and esle if conditionals.  
if (playAgain == "YES")
{
    NewPlayerCode:
    Console.WriteLine($"Great! Is there a new player this time or is just going to be you {userName}? \n Type \"ME\" if it is just you or \"NEW\" if you are starting this game for someone else. ");
    string newPlayer = Console.ReadLine();
    newPlayer.ToUpper();

    if(newPlayer == "ME")
    {
        goto Middle;
    }
    else if (newPlayer == "New")
    {
        Console.WriteLine("Awesome Welcome! Let's get Started !");

        goto StepZero;

    }
    else
    {
        Console.WriteLine("I am sorry you didnt enter the right words lets try this again:");
        goto NewPlayerCode;
    }
}
else if (playAgain == "NO")
{
    Console.WriteLine($"It was great playing with you. Untill next {userName}");

    Environment.Exit(1);
}



