using System;

namespace MunchersandMidgets
{
    class Program
    {


        static void Main(string[] args)
        {
            ClassSelector selector = new ClassSelector();
            Entity myCharacter = selector.Choose();

            myCharacter.PrintAS();

            Console.ReadLine();


        }
    }
}
