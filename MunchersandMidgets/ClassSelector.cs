using System;

namespace MunchersandMidgets
{
    public class ClassSelector
    {
        public string activeClass;
        public string activeSubClass;

        public Entity Choose()
        {
            int classID;
            int subclassID;
            int startingGunID;
            //En metod som kan returnera entitys. Den väljer en klass. med hjälp av en readkey och ett klassid. samt några writelines.
            Console.WriteLine("Hello and Welcome Adventurer!\n Pick Your Desired Class, Which One Speaks To You Adventurer?\n");
            System.Console.WriteLine("Press the corresponding number on the keyboard\n 1. Ranger");
            classID = (int)char.GetNumericValue(Console.ReadKey().KeyChar);
            Console.Clear();

            if (classID == 1)
            {
                System.Console.WriteLine("Ah, a Ranger are you? \n Very Well. Now! Pick your Subclass:\n 1: Gunslinger");
                subclassID = (int)char.GetNumericValue(Console.ReadKey().KeyChar);
                Console.Clear();
                if (subclassID == 1)
                {
                    System.Console.WriteLine("Gunslinger! Wise Choice Cowboy.\n Now pick your starting gun!\n 1. Flintlock\n 2. Six Shooter\n 3. Glock");
                    startingGunID = (int)char.GetNumericValue(Console.ReadKey().KeyChar);
                    Console.Clear();
                    if (startingGunID == 1)
                    {
                        System.Console.WriteLine("Yarr! \n Thy Flintlock is yer weapon of choice\n");
                    }
                    else if (startingGunID == 2)
                    {
                        System.Console.WriteLine("Yeeeehaw!!\n Quickdraw on them zombies\n");

                    }
                    else if (startingGunID == 3)
                    {
                        System.Console.WriteLine("Glocken? Förlängt Mag? \n Brap Brap Gangster Grabb\n");
                    }
                    else
                    {
                        System.Console.WriteLine("Okay, Jackass, Now your starting Gun is a Banana.\n");
                    }
                }
            }
            System.Console.WriteLine("Below You Can Have A Look At Your Statblock.\nAre You A Charming Prince Or A Ferocious Brawler?\n");



            return new Entity();

        }
    }
}