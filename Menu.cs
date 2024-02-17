using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Menu
{
    private void DisplayMenu()
    {
        for (int ferdi = 0; ferdi < 7; ferdi++)
        {
            Console.WriteLine(" ");                                            // Prints blank spaces 7 times
        }
        Console.WriteLine("==============  Menu  ==============");
        Console.WriteLine(" ");
        Console.WriteLine(" 1. Add/Edit an Event");
        Console.WriteLine(" 2. Search for Event");
        Console.WriteLine(" 3. Display all Events");
        Console.WriteLine(" 4. Remove an Event");
        Console.WriteLine(" 5. Quit");
        Console.WriteLine("  ");
        Console.WriteLine("====================================");
        Console.WriteLine(" ");
    }

    private void DisplayAddMenu()
    {
        for (int ferdi = 0; ferdi < 7; ferdi++)
        {
            Console.WriteLine(" ");                                            // Prints blank spaces 7 times
        }
        Console.WriteLine("==========  Add/Edit Menu  =========");
        Console.WriteLine(" ");
        Console.WriteLine(" 1. Add an Event");
        Console.WriteLine(" 2. Edit an Event");
        Console.WriteLine(" 3. Back");
        Console.WriteLine("  ");
        Console.WriteLine("====================================");
        Console.WriteLine(" ");
    }


    public void Initiate()
    {
        bool exit = false;                                  // Determines whether to end the programme
        EventOrganiser eventOrganiser = new EventOrganiser();
        while (true)                                        // Loops Forever until "5" is entered
        {
            DisplayMenu();  
            string option = Console.ReadLine();
            switch (option)        
            {
                case "1":
                    DisplayAddMenu();
                    string optionadd = Console.ReadLine();
                    switch (optionadd)
                    {
                        case "1":
                            eventOrganiser.AddEvent();
                            break;
                          case "2":
                            eventOrganiser.EditEvent();
                            break;
                        default:                                // sends user back to the main menu
                            break;
                    }
                    break;

                case "2":
                    eventOrganiser.SearchEvent();
                    break;

                case "3":
                    eventOrganiser.DisplayEvent();
                    break;

                case "4":
                    eventOrganiser.RemoveEvent();
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("SYSTEM: Error - Unrecognised input");
                    break;
            }

            if(exit)
            {
                break;              // Break out of the Master While Loop
            }
        }
    }
}
