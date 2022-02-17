/**
* 16 Feb 22
* CSC 153
* Jacquelin Velasquez
* This program allows you to move through 5 different rooms.
* This program displays rooms, weapons, potions, treasures, items, and Mobs.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] rooms = {"Entrance", "Lobby", "Concession Stand", "Hall", "Theater Room"};
            string[] weapons = {"Bat", "Knife", "Ax", "Pistol"} ;
            string[] potions = {"Invisiblity Serum", "Super Strength Serum"};
            string[] treasures = {"Diamond", "Extra Life Token", "Instant Kill Token"};
            List<string> items = new List<string>() {"Pen", "Wallet", "Water Bottle", "Notepad" };
            List<string> mobs = new List<string>() {"Jean", "Aaron", "Denali", "Denver", "Moscow" };

            string choice;
            string menuChoice = "Start";
            int counter = 0;
            string currentRoom = rooms[counter];

            Console.WriteLine($"You are in the {currentRoom} ");
            Console.WriteLine("Type north to move to the next room.");
            Console.WriteLine("Type south to go back to the previous room.");
            Console.WriteLine("Type main menu to view the main menu");

            choice = Console.ReadLine();


            while (menuChoice != "exit")
            {
                while (choice != "main menu")
                {

                    if (choice == "north")
                    {
                        if (currentRoom != "Theater Room")
                        {
                            counter++;
                            currentRoom = rooms[counter];

                            Console.WriteLine($"You are in the {currentRoom } ");
                            Console.WriteLine("Type north, south, or main menu.");

                        }
                        else
                        {
                            Console.WriteLine("The Theater Room is the last Room."
                                         + "Type south to go back to the previous room.");
                        }
                    }
                    else if (choice == "south")
                    {
                        if (currentRoom != "Entrance")
                        {
                            counter--;
                            currentRoom = rooms[counter];

                            Console.WriteLine($"You are in the {currentRoom } ");
                            Console.WriteLine("Type north, south, or main menu.");


                        }
                        else
                        {
                            Console.WriteLine("The Entrance Room is the last Room." +
                                              "Type north to go to the next room.");
                        }

                    }
                    else if (choice == "current room")
                    {
                        Console.WriteLine($"You are in the {currentRoom } ");
                        Console.WriteLine("Type north, south, or main menu.");

                    }
                    else
                    {
                        Console.WriteLine("You have entered an invalid command. Please Try again.");
                    }

                    choice = Console.ReadLine();
                }

                if (choice == "main menu")
                {
                    Console.WriteLine("\t\tMain Menu\t\t\n");
                    Console.WriteLine("1. Display Rooms");
                    Console.WriteLine("2. Display Weapons");
                    Console.WriteLine("3. Display Potions");
                    Console.WriteLine("4. Display Treasures");
                    Console.WriteLine("5. Display Items");
                    Console.WriteLine("6. Display Mobs");
                    Console.WriteLine("7. Exit\n");
                    Console.WriteLine("Enter what you would like to do." +
                                      " For Example type rooms to display the rooms");

                    menuChoice = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (menuChoice == "rooms")
                    {
                        foreach (string room in rooms)
                        {
                            Console.WriteLine(room);
                        }
                    }

                    else if (menuChoice == "weapons")
                    {
                       
                        foreach (string weapon in weapons)
                        {
                            Console.WriteLine(weapon);
                        }
                    }

                    else if (menuChoice == "potions")
                    {
                        foreach (string potion in potions)
                        {
                            Console.WriteLine(potion);
                        }
                    }

                    else if (menuChoice == "treasures")
                    {
                        foreach (string treasure in treasures)
                        {
                            Console.WriteLine(treasure);
                        }
                    }
                    else if (menuChoice == "items")
                    {
                        foreach (string item in items)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (menuChoice == "mobs")
                    {
                        foreach (string mob in mobs)
                        {
                            Console.WriteLine(mob);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered an invalid command. Please try again.");
                    }

                    Console.WriteLine("\nType main menu to return to the main menu or current room to continue moving through rooms.");
                    choice = Console.ReadLine();

                }

            }   

        }
    }
}
