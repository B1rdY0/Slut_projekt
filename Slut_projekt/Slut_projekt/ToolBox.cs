using System;
using System.Threading;



public class ToolBox
{

    public static void printStats(int playerHealth, int Boss1Health)
    {
        Console.WriteLine($"you have {playerHealth} HP");
        Thread.Sleep(100);
        Console.WriteLine($"The boss has {Boss1Health}");
    }

    public static int Sword(int Boss1HP)
    {
        int PLHP = 100;
        int PLDMGS1 = 50;
        int BossDMG = 15;


        Random generator = new Random();
        Console.WriteLine("You have 50% to hit or 50% to miss");
        int chance = generator.Next(1);

        if (chance == 0)
        {
            Console.WriteLine("Man you are too slow");
            Thread.Sleep(1500);
            Console.WriteLine("The Boss is attacking");
            Thread.Sleep(1500);
            PLHP -= BossDMG;
            Console.WriteLine($"The boss has {Boss1HP} and you have {PLHP}");
        }

        else
        {
            Console.WriteLine("You damaged the boss");
            Thread.Sleep(1500);
            Boss1HP -= PLDMGS1;
            Console.WriteLine($"You have {PLHP} and the boss has {Boss1HP}");
        }

        return Boss1HP;
    }

    public static int Mace(int Boss1HP)
    {
        int MACEDMG = 25;
        int BossDMG = 15;
        int PLHP = 100;



        Random genaretor1 = new Random();
        Console.WriteLine("You have 50% to hit and 50% to miss");
        int chance2 = genaretor1.Next(1);


        if (chance2 == 1)
        {
            Console.WriteLine("Man you are way too slow with the mace");
            Thread.Sleep(1500);
            Console.WriteLine("The boss is about to attack");
            Thread.Sleep(1500);
            PLHP -= BossDMG;
            Console.WriteLine($"The boss has {Boss1HP} and you have {PLHP}");
        }



        else
        {
            Console.WriteLine("You have damaged the boss");
            Thread.Sleep(1500);
            Boss1HP -= MACEDMG;
            Console.WriteLine($"You have {PLHP} and the boss har {Boss1HP}");
        }

        return Boss1HP;

    }


    public static int Scythe(int Boss1HP)
    {

        int ScytheDMG = 75;
        int BossDMG = 15;
        int PLHP = 100;


        Random genarator2 = new Random();
        Console.WriteLine("You have 50% to hit and 50% miss");
        int chance3 = genarator2.Next(1);

        if (chance3 == 1)
        {
            Console.WriteLine("You are too slow with the Scythe");
            Thread.Sleep(1500);
            Console.WriteLine("The boss is attacking");
            Thread.Sleep(1500);
            PLHP -= BossDMG;
            Console.WriteLine($"You have {PLHP} and the boss has {Boss1HP}");

        }

        else
        {
            Console.WriteLine("You damaged the boss");
            Thread.Sleep(1500);
            Boss1HP -= ScytheDMG;
            Console.WriteLine($"You have {PLHP}and the boss has {Boss1HP}");
        }

        return Boss1HP;


    }




}
