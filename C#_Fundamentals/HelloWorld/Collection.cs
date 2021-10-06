using System;
using System.Collections.Generic;

namespace CollectionFunction
{
    public class CollectionFunction
    {
//Generic Collection
        List<string> strings = new List<string>();
    /*Default constructor
    public Collection()
    {

    }
    */
       // public Collection
        public void CollectionMain()
        {
            Console.WriteLine("Collection Demo");
            Console.WriteLine("List Demo");
            
            //Adding new elements to a collection
            strings.Add("First element");
            strings.Add("Second element");
        //A way to go through a list
        //Foreach will iterate through all elements of a collection
            Console.WriteLine("Looping...Looping...")
            foreach(string thisIsAString in strings);
            {
                Console.WriteLine(thisIsAString);
            }

                Console.WriteLine("For Loop Demo);
                for (int i = 0; i < strings.Count; i+=2)
            {
                Console.WriteLine("The current i variable holds: "+i)
                Console.WriteLine(strings[i]);
            }

        }

    }
    //Convention: Make one Class per file.
}