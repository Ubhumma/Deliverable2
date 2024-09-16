/*
 Build Specifications
-The challenge should only run if the user agrees to it.
-If the user doesn’t agree, call them a coward and end the program without doing the challenge.
-The challenge should have five rounds.
-During each round the program secretly picks a random number: 0 or 1
-Ask the user for heads or tails. Compare it to the random number.
-These won’t nicely compare. You will have to come up with how heads and tails relate to 0 and 1.
-Each right answer adds one to the total.

 */
using System.CodeDom.Compiler;
using System.Data;

int userScore = 0;

Console.WriteLine("Hello Challenger! What is your name?");
string userName = Console.ReadLine();
Console.WriteLine("Welcome, " + userName + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No" );
string userChallenge = Console.ReadLine();

if ((userChallenge == "Yes") || (userChallenge == "YES") || (userChallenge == "yes") || (userChallenge == "y") || (userChallenge == "Y") ){
    //While loop used to seamlessly repeat the game without completely closing and reopening the code by the user if wanted. 
    while ((userChallenge == "Yes") || (userChallenge == "YES") || (userChallenge == "yes") || (userChallenge == "y") || (userChallenge == "Y"))
    {
        userScore = 0;
        for (int round = 1; round <= 5; round++)
        {
            //initialization of my vars used to calc between Heads, Tails, and the random numbers. Also resets all values for rounds.
            bool Heads = false;
            bool Tails = false;
            string userAnswer = "";
            

            //Figured out the gist of this Class through using Microsoft's documentation.
            Random rnd = new Random();
            //First we'll ask heads or tails, then flip, then find out if the user answer matches the flip. If so, we'll add a point to the user's score.
            Console.WriteLine("Heads or Tails?");
            userAnswer = Console.ReadLine();

            int cFlipResults = (rnd.Next(2));
            // debuffing print statement: Console.WriteLine(cFlipResults);
            //Translates 0 and 1 into Heads and Tails
            if (cFlipResults == 0)
            {
                Heads = true;
            }
            else if (cFlipResults == 1)
            {
                Tails = true;
            }

            if (((userAnswer == "Heads") && (Heads == true)) || ((userAnswer == "Tails") && (Tails == true)))
            {
                userScore++;
                Console.WriteLine("Congrats " + userName + ", You guessed correctly! One point has been added to your score.");
            }

        }
        Console.WriteLine("Congrats! Your score is " + userScore + ". Nice going.");
        Console.WriteLine("Would You like to repeat the challenge, " + userName +"?");
        userChallenge =  Console.ReadLine();
    }
}
if ((userChallenge == "No") || (userChallenge == "NO") || (userChallenge == "no") || (userChallenge == "n") || (userChallenge == "N"))
{
    Console.WriteLine("You are a coward, " + userName);
    return;
}

/*
- Ask the user for their name and store it.
-The name is used throughout the program
-The user is called a coward if they do not agree to the COIN FLIP CHALLENGE
-Only do the COIN FLIP CHALLENGE if the user agrees.
-Loop the challenge 5 times
-The program grabs a random number between 0 and 1 (You still get this point even if nothing is done with it.)
-The user is asked for heads or tails and their value is stored.
-A solution was found to compare the random number to the heads or tails input that works.
-Every correct answer adds one to the score.
-The score is displayed at the end of the challenge

 */



















/*
 P.S I don't have the program call the user a coward if they refuse to replay because they already showed bravery by taking on the challenge in the first place.
||definitely not because I couldn't figure out how to loop it back to the question of if they refused the challenge without clunking up the code too much.||
I do intend to return to this at a later time to make it more concise, but for now I'm satisfied with my code. NEVERMIND! AS SOON AS I WROTE THIS, THE ANSWER HIT ME IN THE FACE.
At first I had the "if (userChallenge == No)" above the "if (userChallenge == Yes)", which was originally an "else if". I realized that if I changed them both to "if" then they would 
both be ran and that since the "if no" meant the end of the program anyway, it doesn't even make sense for it to be at the top. This way if userChallenge was a no it would ignore
the first "if" statement anyway and simply end the program. Otherwise the user could stay in a yes loop for as long as they like and when their answer was no longer yes, they would move
down to the "if userChallenge == "no" statement. Hope this wall of text is allowed, Ill remove if not. I was just proud of figuring out this problem. :)
 */
