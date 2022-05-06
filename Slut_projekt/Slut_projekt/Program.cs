using System;
using System.Threading;

string startAgain = "yes";

while (startAgain == "yes")     //Om du ska starta igen så börjar du från början
{

    string name = "";                               //man skriver sitt namn
    RoomNames currentRoom = RoomNames.Start;        // skapar variabler för att göra dem olika rummen

    Console.WriteLine("Please press enter when it stops coming text");

    while (name.Length <= 1 || name.Length > 12)            //kollar att namnen inte ska vara mindre eller längre
    {                                                       // än 1 och 12 bokstäver eller number
        Console.WriteLine($"Type your name here:");
        name = Console.ReadLine();

        if (name.Length <= 2 || name.Length >= 1)
        {
            Console.WriteLine("your name is too Short");
            Console.WriteLine("please type again");
        }

        if (name.Length < 1)
        {
            Console.WriteLine("Please enter a valid name");
        }

        else if (name.Length > 12)
        {
            Console.WriteLine("Your name is too Long");
            Console.WriteLine("Please type again");
        }
    }

    int CashMoney = 0;
    int Bank = 0;
    int PLHP = 100;
    int Boss1HP = 500;
    string answer = "Sword";
    answer = Console.ReadLine();      //Svart blir vad du skriver
    answer.ToLower();                  //



    while (currentRoom != RoomNames.End)                           // När den ska börja om så börjar den här
    {
        if (currentRoom == RoomNames.Start)                        // Första rummen 
        {
            ToolBox.printStats(PLHP, Boss1HP);          // Metod som ändrar player HP och Boss HP
            Console.WriteLine("");
            Console.WriteLine($"Welcome to the first room {name}");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine($"There is going to be a choice {name}");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Please choose the right answer");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("what is better: 1. touch grass  2. play Leauge of Legends");
            string action = Console.ReadLine();


            if (action == "1")                         // Säger vad den ska gå efter man har vallt 1
            {
                currentRoom = RoomNames.Arena;          // Arena där första bossen är 
            }

            if (action == "2")
            {
                currentRoom = RoomNames.Unworthy;       // hamnar i ett rum där spelet stängs av 
            }

        }

        //Vad som händer när du väljer 2
        else if (currentRoom == RoomNames.Unworthy)
        {
            Console.WriteLine($"Bruh you are not worthy of playing the game, please QUIT GAME NOW {name}!!!!");

        }

        //Arenan 
        else if (currentRoom == RoomNames.Arena)
        {
            while (Boss1HP > 0 && PLHP > 0)   //Om bossen och Playern är inte 0 så börjar while loopen
            {
                answer = "";                 //Vad du skriver blir variablen

                while (answer != "1" && answer != "2" && answer != "3")      // Du måste välja en av 1,2 eller 3 för att komma vidare annars loopar frågan
                {
                    Console.WriteLine($"Please choose a weapon {name}");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    Console.WriteLine("please choose:   1: Sword   2: Mace   3: Scythe");
                    answer = Console.ReadLine();

                }


                if (answer == "1")                  //När man väljer 1
                {
                    (Boss1HP, PLHP) = ToolBox.Sword(Boss1HP, PLHP);  //Byter värdet på Boss HP och Player HP i Metoden
                }


                if (answer == "2")
                {
                    (Boss1HP, PLHP) = ToolBox.Mace(Boss1HP, PLHP);
                }

                if (answer == "3")
                {
                    (Boss1HP, PLHP) = ToolBox.Scythe(Boss1HP, PLHP);
                }

                else           //Annars så stängs spelet
                {
                    Console.ReadLine();
                }

            }

            Bank += 1000;              //hur mycket pengar du har i banken 

            //när bossen är död så ska den stora If funktionen starta
            if (Boss1HP <= 0)
            {

                bool Broke = false;       // Om man är inte är fattig 

                while (Broke != true)               // om du är inte är fattig så ska loopen starta
                {
                    Console.WriteLine($"you have {Bank} in the bank");
                    Console.WriteLine("You have to cash out the money to buy the items");
                    Console.WriteLine("please cash out any number between 200 - 500");
                    string input = Console.ReadLine();

                    Broke = int.TryParse(input, out CashMoney);             //Hur mycket du sätter in mellan 0 -1000 byter, int till en string 

                    if (CashMoney > 500 || CashMoney < 200)                  //Vad som händer när du inte fyller kriterierna 
                    {
                        Console.WriteLine("Sorry not possible for cash out");
                        Thread.Sleep(1500);
                        Console.WriteLine("You typed a number too high or too low");
                        Console.ReadLine();

                    }

                    else if (CashMoney < 500 && CashMoney > 200)         // Vad som händer när du fyller kriterierna, altså du går vidare till shop
                    {
                        Console.WriteLine("Welcome to the shop");
                        currentRoom = RoomNames.Shop;    //Byter rum 

                    }
                }

            }


            if (currentRoom == RoomNames.Shop)        //Vad som händer i den här rummen (Shop)
            {

                Console.WriteLine("There is 5 items and you can only afford a 1 item");
                Thread.Sleep(1500);
                Console.WriteLine("please type in the number 1, the other number are out of stock at the moment ");
                Console.WriteLine("");
                Console.WriteLine("please press enter to continue");
                Console.WriteLine("The options are");
                Console.WriteLine("1:                   Drugs: Price is 400");
                Console.WriteLine("2:                   steroids: Price is 300 ");
                Console.WriteLine("3:                   Dark heart: Price is 500");
                Console.WriteLine("4:                   Sword of the Gods: Price is 500");
                Console.WriteLine("5:                   Eternal youth: Price is 400");

                string answerItem;
                answerItem = Console.ReadLine();                //tar svaren som är given på alternativen uppe
                answerItem = answerItem.ToLower();

                if (answerItem == "1")                  // Startar en funktion där du går till nästa level(rum)
                {
                    Console.WriteLine("Then please proceed to the next level");
                    Bank -= 400;    //Tar ut pengr när du har köpt
                }

            }

        }


        if (PLHP <= 0)          //När player dör så kommer du att få starta igen eller sluta 
        {
            currentRoom = RoomNames.End;
        }

    }

    startAgain = ToolBox.Try();

}

enum RoomNames                                      //Skapar egna variabler som är ställen som player kommer vara
{
    Start, Arena, Unworthy, End, Shop
};