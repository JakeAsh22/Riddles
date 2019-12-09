using System;
using System.Collections.Generic;
    class Riddle
    {
    
    public static Dictionary <string,string> riddles = new Dictionary<string,string>(){{"riddleOne" , "Two sons and two fathers go on a fishing trip.  When they return that night, they have each caught one fish, but only have 3 fish amoung them.  How is this possible? (They kept every fish caught): "}, {"riddleTwo" , "The person that builds it doesn't want it, the person that buys it doesn't use it, and the person that uses it doesn't know it.  What is it?"} , {"riddleThree", "You are walking down a road and arrive at a fork that splits the road into two separate paths. When you reach, you meet two identical twins, each standing at the edge of one of the two paths. You have heard that there is a bag with $1,000,000 at the end of one path and you are told that one of the two twins always tells the truth and the other always lies. There is no way you can get to the end of both roads before the sun goes down.  What ONE question can you ask (of only one twin) that would lead you to the money?"}};
    public static Dictionary <string,string> riddleAns = new Dictionary<string,string>(){{"riddleOne","A son, father, and grandfather go fishing"},{"riddleTwo","A coffin"},{"riddleThree","Ask what the sister will tell you, and then do the opposite"}};
    public static List <string> riddlesList = new List <string>{"riddleOne","riddleTwo","riddleThree"};
     static void Main ()
     {
         AskRiddles();
        //  Console.WriteLine(riddlesList[0]);
        //  Console.WriteLine(riddlesList.Count);
        //  riddles.Remove("riddleOne");
        //  Console.WriteLine(riddles["riddleOne"]);
        //  Console.WriteLine(riddleOne);
        //  string riddleOneUserAnswer = Console.ReadLine();
        //  if (riddleOneUserAnswer != riddleOneAnswer) {
        //      Console.WriteLine("You got eaten!");
        //  } else {
        //      Console.WriteLine("You done massive damage to the Sphinx, nice job!");
        //     Console.WriteLine(riddleTwo);
        //     string riddleTwoUserAnswer = Console.ReadLine();
        //     if (riddleTwoUserAnswer != riddleTwoAnswer) {
        //         Console.WriteLine("You got eaten!");
        //     } else {
        //         Console.WriteLine("You defeated the Sphinx! Good job!");
        //     }
        //  }
     }   
        static void AskRiddles ()
        {
            Random rnd = new Random();
            int ranRiddle = rnd.Next(0,riddlesList.Count-1);
            string riddleFind = riddlesList[ranRiddle];
            Console.WriteLine(riddles[riddleFind]);
            string userAns = Console.ReadLine();
            if (userAns == riddleAns[riddleFind])
            {
                Console.WriteLine("Nice! You've done a lot of damage to the Sphinx, one more and you should defeat it!");
                riddlesList.Remove(riddlesList[ranRiddle]);
                ranRiddle = rnd.Next(0,riddlesList.Count-1);
                riddleFind = riddlesList[ranRiddle];
                Console.WriteLine(riddles[riddleFind]);
                userAns = Console.ReadLine();
                if (userAns == riddleAns[riddleFind])
                {
                    Console.WriteLine("Nice Work! You defeated the Sphinx!");
                }
                else
                {
                    Console.WriteLine("Dang, you almost had it.  Too bad that you're now Sphinx food.");
                }
            }
            else
            {
                Console.WriteLine("Darn, wrong answer.  You were eaten.");
            }
            //  string riddleOne = "Two sons and two fathers go on a fishing trip.  When they return that night, they have each caught one fish, but only have 3 fish amoung them.  How is this possible? (They kept every fish caught): ";
            //  string riddleOneAnswer = "There were only three people who went on the trip. A son, a father, and a grandfather.";
            // string riddleTwo = "The person that builds it doesn't want it, the person that buys it doesn't use it, and the person that uses it doesn't know it.  What is it?";
            //  string riddleTwoAnswer = "A coffin";
        }
    }