using System;
using System.Collections.Generic;
namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showRooms = new HashSet<string>();

            showRooms.Add("Tesla");
            showRooms.Add("Porsche");
            showRooms.Add("Alfa Romeo");
            showRooms.Add("Chevrolet");
            showRooms.Add("Tesla");

            HashSet<string> usedLot = new HashSet<string>();

            usedLot.Add("BMW");
            usedLot.Add("Toyota");

            showRooms.UnionWith(usedLot);

            showRooms.Remove("BMW");

            HashSet<string> Junkyard = new HashSet<string>();
            
            Junkyard.Add("Chevrolet");
            Junkyard.Add("Ford");
            Junkyard.Add("Nissan");
            Junkyard.Add("Honda");
            Junkyard.Add("Alfa Romeo");

            HashSet<string> clone = new HashSet<string>(showRooms);

            clone.IntersectWith(showRooms);

            showRooms.UnionWith(Junkyard);

            showRooms.Remove("Ford");

            System.Console.WriteLine(showRooms.Count);
        }
    }
}
