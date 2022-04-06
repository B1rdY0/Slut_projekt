using System;
using System.Threading;


string name = "";                               //man skriver sitt namn
RoomNames currentRoom = RoomNames.Start;        // skapar variabler för att göra dem olika rummen



while (name.Length <= 1 || name.Length > 12)            //kollar att namnen inte ska vara mindre eller längre
{                                                       // än 1 och 12 bokstäver eller number
    Console.WriteLine($"Type your name here:");
    name = Console.ReadLine();
    if (name.Length <= 2)
    {
        Console.WriteLine("your name is too Short");
        Console.WriteLine("please type again");
    }

    else if (name.Length > 12)
    {
        Console.WriteLine("Your name is too Long");
        Console.WriteLine("Please type again");
    }

}



int PLHP = 100;
int Boss1HP = 500;
ToolBox.printStats(PLHP, Boss1HP);          //
string answer = "Sword";
answer = Console.ReadLine();
answer.ToLower();



while (currentRoom != RoomNames.End)
{
    if (currentRoom == RoomNames.Start)
    {

        Console.WriteLine($"Welcome to Room1 {name}");
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


        if (action == "1")
        {
            currentRoom = RoomNames.Arena;
        }

        if (action == "2")
        {
            currentRoom = RoomNames.Unworthy;
        }

    }

    if (currentRoom == RoomNames.Unworthy)
    {
        Console.WriteLine($"Bruh you are not worthy of playing the game, please QUIT GAME NOW {name}!!!!");

    }


    if (currentRoom == RoomNames.Arena)
    {
        answer = "";
        while (Boss1HP != 0 && PLHP != 0)
        {

            while (answer != "1" && answer != "2" && answer != "3")
            {
                Console.WriteLine($"Please choose a weapon {name}");
                Console.WriteLine("");
                Thread.Sleep(1000);
                Console.WriteLine("please choose:   1: Sword   2: Mace   3: Scythe");
                answer = Console.ReadLine();

            }


            if (answer == "1")
            {
                (Boss1HP, PLHP) = ToolBox.Sword(Boss1HP, PLHP);
            }


            if (answer == "2")
            {
                (Boss1HP, PLHP) = ToolBox.Mace(Boss1HP, PLHP);
            }

            if (answer == "3")
            {
                (Boss1HP, PLHP) = ToolBox.Scythe(Boss1HP, PLHP);
            }

            else
            {
                Console.ReadLine();
            }
        }

    }


    Console.ReadLine();
}


enum RoomNames
{
    Start, Arena, Unworthy, End
};