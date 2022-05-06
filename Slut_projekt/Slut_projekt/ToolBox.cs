using System;
using System.Threading;

// Alla metoder 

public class ToolBox
{

    public static void printStats(int playerHealth, int Boss1Health)
    {
        Console.WriteLine($"you have {playerHealth} HP");           //Skriver ut både player HP och Boss HP
        Thread.Sleep(100);
        Console.WriteLine($"The boss has {Boss1Health}");
    }

    //Dem tre gör samma sak i princip
    public static (int, int) Sword(int BossHP, int playerHp)   //Metod som säger vad Sword ska göra och vad bossen ska göra
    {
        int PLDMGS1 = 250;
        int BossDMG = 80;


        Random generator = new Random();    //Gör en chance om när han attackerar eller om bossen missar
        Console.WriteLine("You have 50% to hit or 50% to miss");
        int chance = generator.Next(1);


        if (chance == 0)           // Vad som händer om bossen attackerar 
        {
            Console.WriteLine("Man you are too slow");
            Thread.Sleep(1500);
            Console.WriteLine("The Boss is attacking");
            Thread.Sleep(1500);
            playerHp -= BossDMG;
            Console.WriteLine($"The boss has {BossHP} and you have {playerHp}");
        }

        else    // Vad som annars händer om du gör skada till bossen
        {
            Console.WriteLine("You damaged the boss");
            Thread.Sleep(1500);
            BossHP -= PLDMGS1;
            Console.WriteLine($"You have {playerHp} and the boss has {BossHP}");
        }


        return (BossHP, playerHp);  //Uppdaterar HP för våda bossen och playern
    }

    public static (int, int) Mace(int Boss1HP, int playerHp)  //Metod som säger vad Mace ska göra och vad bossen ska göra 
    {
        int MACEDMG = 300;
        int BossDMG = 15;



        Random genaretor1 = new Random();       //gör Random
        Console.WriteLine("You have 50% to hit and 50% to miss");
        int chance2 = genaretor1.Next(1);       // gör en 50/50 på det


        if (chance2 == 1)     //Om du missar så gör bossen skada på player
        {
            Console.WriteLine("Man you are way too slow with the mace");
            Thread.Sleep(1500);
            Console.WriteLine("The boss is about to attack");
            Thread.Sleep(1500);
            playerHp -= BossDMG;
            Console.WriteLine($"The boss has {Boss1HP} and you have {playerHp}");
        }



        else   //När bossen gör skada 
        {
            Console.WriteLine("You have damaged the boss");
            Thread.Sleep(1500);
            Boss1HP -= MACEDMG;
            Console.WriteLine($"You have {playerHp} and the boss has {Boss1HP}");  // vissar vad värden på dem nya HP är
        }

        return (Boss1HP, playerHp);    //Uppdaterar Hp för nästa level 

    }


    public static (int, int) Scythe(int Boss1HP, int playerHp)   //Metod som säger vad Scythe ska göra och vad bossen ska göra
    {

        int ScytheDMG = 75;
        int BossDMG = 15;


        Random genarator2 = new Random();
        Console.WriteLine("You have 50% to hit and 50% miss");
        int chance3 = genarator2.Next(1);

        if (chance3 == 1)
        {
            Console.WriteLine("You are too slow with the Scythe");
            Thread.Sleep(1500);
            Console.WriteLine("The boss is attacking");
            Thread.Sleep(1500);
            playerHp -= BossDMG;
            Console.WriteLine($"You have {playerHp} and the boss has {Boss1HP}");

        }

        else
        {
            Console.WriteLine("You damaged the boss");
            Thread.Sleep(1500);
            Boss1HP -= ScytheDMG;
            Console.WriteLine($"You have {playerHp}and the boss has {Boss1HP}");
        }

        return (Boss1HP, playerHp);


    }


    public static string Try()     //Om du dör så ska du gå tillbaka till början
    {
        Console.WriteLine("You have died");
        Console.WriteLine("");
        Thread.Sleep(1500);
        Console.WriteLine("Do you want to try again? or give up?");
        Console.WriteLine("");
        Thread.Sleep(1500);
        Console.WriteLine("please choose 1 or 2");
        Console.WriteLine("1: try again    2: give up");

        return Console.ReadLine();      //Tar imot svaret och beroende på vad det är så går den till början eller slutar spelt
    }


}
