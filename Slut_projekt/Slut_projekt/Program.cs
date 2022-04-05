using System;
using System.Threading;


string name = "";
RoomNames currentRoom = RoomNames.Start;



while (name.Length <= 1 || name.Length > 12)
{
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
ToolBox.printStats(PLHP, Boss1HP);
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
        // string LOL = Console.ReadLine();


        if (action == "touch grass")
        {
            currentRoom = RoomNames.Arena;
        }

        if (action == "Leauge of Legends")
        {
            currentRoom = RoomNames.Unworthy;
        }
    }


    if (currentRoom == RoomNames.Arena)
    {
        answer = "";
        while (answer != "Sword" && answer != "Mace" && answer != " scythe")
        {
            Console.WriteLine($"Please choose a weapon {name}");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("please choose:   1: Sword     2: Mace      3: Scythe");
            answer = Console.ReadLine();

        }


        if (answer == "Sword")
        {
            Boss1HP = ToolBox.Sword(Boss1HP);
        }


        if (answer == "Mace")
        {
            Boss1HP = ToolBox.Mace(Boss1HP);
        }

        if (answer == "Scythe")
        {
            Boss1HP = ToolBox.Scythe(Boss1HP);
        }


    }

    if (currentRoom == RoomNames.Unworthy)
    {
        Console.WriteLine($"Bruh you are not worthy of playing the game, please QUIT GAME NOW {name}!!!!");

    }

    Console.ReadLine();
}


enum RoomNames
{
    Start, Arena, Unworthy, End
};