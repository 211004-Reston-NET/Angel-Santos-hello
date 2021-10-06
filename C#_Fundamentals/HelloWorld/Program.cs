using System;
using HouseFunction;


namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World!");
            Program.Example();

            House Angel = new House();


            //We displayed those changed values into the terminal
            //Console.WriteLine(Angel.Owner);
            Console.WriteLine("Write some stuff USER and have it spat back at ya!");
            Angel.TerminalInput = Console.ReadLine();
            Console.WriteLine(Angel.TerminalInput);


            Collection collectionObj = new Collection();
        }
        
        public static int Example()
        {
            return 10;
        }
        
    }
}