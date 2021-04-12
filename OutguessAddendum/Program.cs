using System;
using System.Runtime.CompilerServices;

namespace OutguessAddendum {
    class Program {
        static void Main(string[] args) {
            
            //Variables
            int userGuess = 0;
            Random rnd_maker = new Random();
            int rndNum = 2; //rnd_maker.Next(1,100);         
            double userMoney = 0.0;
            double userWager = 0.0;
            int guessBet = 0;
            double betMultiplier = 0.0;
            string playAgain = "y";
            double userPlays = 0.0;
            double userWins = 0.0;   
            double winPercentage = 0.0;

            

            //Present info to user and get input
            Console.WriteLine("Welcome to Outguess!");
            Console.WriteLine("I've chosen a number between 1 and 100.  You have 10 chances to guess the number.  Good luck!");





            //Ask User To Enter Starting Amount Of Money
            Console.Write("How much money did you bring to the table with you?  $");
            userMoney = double.Parse(Console.ReadLine());

                do{
                      Console.Write("How many guesses would you like to use?  ");
                      guessBet = int.Parse(Console.ReadLine());
                }while (guessBet > 10);
                 userPlays = userPlays + 1;

                       
            //Wager Prompt
                do {
                    Console.Write("How much would you like to wager?  $");
                    userWager = double.Parse(Console.ReadLine());
                }while (userWager > userMoney);
                userMoney = userMoney - userWager;
               
               




            //While Statement
            while (playAgain == "y") {


                                //Ask User For Guess Amount


               //Validation Loop For The Number Range
               do {
                Console.WriteLine("Please enter a number within the range of 1-100");
                userGuess = int.Parse(Console.ReadLine());
               } while (userGuess < 1 || userGuess > 100);

                
                           
                 
                  
                 guessBet = guessBet - 1;
                 betMultiplier = (userWager * 10) / 1;


              

                //If else statements for outcomes.
                 if (userGuess == rndNum) {
                    Console.WriteLine("Congratulations!  You guessed the correct number which is {0}.  You have won ${1}. Would you like to play again?  Enter y for yes or n for no.", rndNum, betMultiplier);                 
                    userWins = userWins + 1;
                    userMoney = userMoney + betMultiplier;
                    playAgain = Console.ReadKey(true).KeyChar.ToString().ToLower();

                    

                 }else if (userGuess < rndNum && userMoney >= 0 && guessBet > 0) {
                     Console.WriteLine("Sorry that's too low!  You have {0} guesses remaining and ${1} left to use.", guessBet, userMoney);

                 }else if (userGuess > rndNum && userMoney >= 0 && guessBet > 0) {
                    Console.WriteLine("Sorry that's too high!  You have {0} guesses remaining and ${1} left to use.", guessBet, userMoney);

                 }else if (userGuess!= rndNum && userMoney == 0 && guessBet == 0) {
                    Console.WriteLine("I'm sorry.  You lose. You are out of remaining funds.  The number was {0}.", rndNum);                 
                    break;

                 }
                 
                 if (guessBet == 0) {


                    if (userMoney > 0) {
                        Console.WriteLine("Would you like to play again? Enter y for yes or n for no.");
                        playAgain = Console.ReadKey(true).KeyChar.ToString().ToLower();

                        Console.WriteLine("You have ${0} available to use.", userMoney);

                        if(playAgain == "y") {

                                 do{
                                    Console.Write("How many guesses would you like to use?  ");
                                         guessBet = int.Parse(Console.ReadLine());
                                 }while (guessBet > 10);
                                        userPlays = userPlays + 1;

                        do {
                            Console.Write("How much would you like to wager?  $");
                            userWager = double.Parse(Console.ReadLine());  
                                
                        }while (userWager > userMoney);

                        userMoney = userMoney -= userWager;                        
                        }//End PlayAgain If
                    } else {
                        playAgain = "n";
                    }//End 
                    
                 

                }//End else















            }//End While





            //Present User With Win Percentage After Qutting Or Running Out Of Money
            do {
                Console.WriteLine("Your win percentage is {0}.", winPercentage);
                winPercentage = userWins / userPlays;
                Console.ReadKey();
            }while (playAgain == "n" || userMoney == 0);







        }//End Main

        //Create a function for the betmultiplier to plug in for amount of guesses
        ////Get rid of original bet multiplier 

    }//End Class
}//End Namespace

