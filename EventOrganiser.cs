using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EventOrganiser
{
    private List<Events> TheEvents = new List<Events>();
    private List<int> EventIDs = new List<int>();
    Random randomID = new Random();

    public void AddEvent()
    {
        Events NewEvent = new Events();
        Console.WriteLine(" ");
        Console.WriteLine("SYSTEM: New Process - Adding event. ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        int TheId = randomID.Next(1000, 10000);
        while (EventIDs.Contains(TheId))                            // Keeps looping to find a new id number until there is a new unique number to ebe assigned to an event
        {
            TheId = randomID.Next(1000, 10000);
        }
        NewEvent.ID = TheId;
        EventIDs.Add(TheId);
        Console.WriteLine("Auto generated ID: #{0}", TheId);
        Console.WriteLine(" ");
        Console.Write("Enter the Event Title (Case Sensitive): ");
        NewEvent.Title = Console.ReadLine();
        bool checkingfortitle = false;
        foreach(Events ferdi in TheEvents)
        {
            if(ferdi.Title == NewEvent.Title)
            {
                Console.WriteLine("SYSTEM: Error - Event already exists ");
                checkingfortitle = true;
            }
        }
        if (checkingfortitle == false)                                              // this is so two events with the same title arent created as this may have complications in the future even if they have different IDs
        {
            Console.WriteLine(" ");
            Console.WriteLine("Enter the Event Description: ");
            Console.WriteLine(" ");
            NewEvent.Description = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Enter Date and Time in DD/MM/YYYY HH:MM : ");
            Console.WriteLine(" ");
            NewEvent.DueDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            TheEvents.Add(NewEvent);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("SYSTEM: New event saved. ");
        }
    }

    public void EditEvent()                                             // i could use a foreach loop and then track the index the event is found at, display it originally and then as them to enterr the new details and then just write over it at the same index
    {
        Console.WriteLine(" ");
        Console.WriteLine("SYSTEM: New Process - Editing event. ");
        Console.WriteLine(" ");
        Console.WriteLine("1. Search ID");
        Console.WriteLine("2. Search Title");
        Console.WriteLine(" ");
        Console.Write("Enter option: ");
        string option = Console.ReadLine();
        bool runmethod = true;                                          // this decides whether or not the method gets executed or not, if not it takes the user back to the main menu
        if (option != "1" && option != "2")
        {
            Console.WriteLine(" ");
            Console.WriteLine("SYSTEM: Error - Unrecognised input");
            Console.WriteLine(" ");
            runmethod = false;
        }
        if(option == "1" && runmethod == true)
        {
            Console.WriteLine(" ");
            Console.Write("Enter ID: #");
            int SearchID = Convert.ToInt32(Console.ReadLine());
            bool searchfound = false;
            foreach (Events ferdi in TheEvents)
            {
                if (ferdi.ID == SearchID)
                {
                    Console.WriteLine("SYSTEM: Event found. ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Event ID: #{0}", ferdi.ID);
                    Console.WriteLine(" ");
                    Console.WriteLine("Current Event Title: {0}", ferdi.Title);                     // Displays the old event information
                    Console.WriteLine(" ");
                    Console.WriteLine("Current Event Description: {0}", ferdi.Description);
                    Console.WriteLine(" ");
                    Console.WriteLine("Current Event Date and Time: {0}", ferdi.DueDate);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.Write("Enter New Event Title (Case Sensitive): ");
                    ferdi.Title = Console.ReadLine();                                               // Allows the user to edit and add new information
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter New Event Description: ");
                    Console.WriteLine(" ");
                    ferdi.Description = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter New Date and Time in DD/MM/YYYY HH:MM : ");
                    Console.WriteLine(" ");
                    ferdi.DueDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("SYSTEM: New event saved. ");
                    searchfound = true;
                    break;
                }
            }
            if (searchfound == false)
            {
                Console.WriteLine("SYSTEM: Event with ID: '#{0}' Cannot be found.", SearchID);
            }
        }
        if(option == "2" && runmethod == true)
        {
            Console.WriteLine(" ");
            Console.Write("Enter Title: ");
            string SearchTitle = Console.ReadLine();
            bool searchfound = false;
            foreach (Events ferdi in TheEvents)
            {
                if (ferdi.Title == SearchTitle)
                {
                    Console.WriteLine("SYSTEM: Event found. ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Event ID: #{0}", ferdi.ID);
                    Console.WriteLine(" ");
                    Console.WriteLine("Current Event Title: {0}", ferdi.Title);                     // Displays the old event information
                    Console.WriteLine(" ");
                    Console.WriteLine("Current Event Description: {0}", ferdi.Description);
                    Console.WriteLine(" ");
                    Console.WriteLine("Current Event Date and Time: {0}", ferdi.DueDate);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.Write("Enter New Event Title (Case Sensitive): ");
                    ferdi.Title = Console.ReadLine();                                               // Allows the user to edit and add new information
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter New Event Description: ");
                    Console.WriteLine(" ");
                    ferdi.Description = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter New Date and Time in DD/MM/YYYY HH:MM : ");
                    Console.WriteLine(" ");
                    ferdi.DueDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("SYSTEM: New event saved. ");
                    searchfound = true;
                    break;
                }
            }
            if (searchfound == false)
            {
                Console.WriteLine("SYSTEM: Event with Title: '{0}' Cannot be found.", SearchTitle);
            }
        }
    }

    public void SearchEvent()
    {
        Console.WriteLine(" ");
        Console.WriteLine("SYSTEM: New Process - Searching event. ");
        Console.WriteLine(" ");
        Console.WriteLine("1. Search IDs");
        Console.WriteLine("2. Search Titles");
        Console.WriteLine(" ");
        Console.Write("Enter option: ");
        string option = Console.ReadLine();
        bool runmethod = true;                                          // this decides whether or not the method gets executed or not, if not it takes the user back to the main menu
        if (option != "1" && option != "2")
        {
            Console.WriteLine(" ");
            Console.WriteLine("SYSTEM: Error - Unrecognised input");
            Console.WriteLine(" ");
            runmethod = false;
        }
        if(option == "1" && runmethod == true)                                                                   // Searching with ID
        {
            Console.WriteLine(" ");
            Console.Write("Enter ID: #");
            int SearchID = Convert.ToInt32(Console.ReadLine());
            bool searchfound = false;
            foreach (Events ferdi in TheEvents)
            {
                if (ferdi.ID == SearchID)
                {
                    Console.WriteLine("SYSTEM: Event found. ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Event ID: #{0}", ferdi.ID);
                    Console.WriteLine(" ");
                    Console.WriteLine("Event Title: {0}", ferdi.Title);
                    Console.WriteLine(" ");
                    Console.WriteLine("Event Description: {0}", ferdi.Description);
                    Console.WriteLine(" ");
                    Console.WriteLine("Event Date and Time: {0}", ferdi.DueDate);
                    searchfound = true;
                    break;
                }
            }
            if (searchfound == false)
            {
                Console.WriteLine("SYSTEM: Event with ID: '#{0}' Cannot be found.", SearchID);
            }
        }
        if(option == "2" && runmethod == true)                                                                       // Searching with Title
        {
            Console.WriteLine(" ");
            Console.Write("Enter Title: ");
            string SearchTitle = Console.ReadLine();
            bool searchfound = false;
            foreach (Events ferdi in TheEvents)
            {
                if (ferdi.Title == SearchTitle)
                {
                    Console.WriteLine("SYSTEM: Event found. ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Event ID: #{0}", ferdi.ID);
                    Console.WriteLine(" ");
                    Console.WriteLine("Event Title: {0}", ferdi.Title);
                    Console.WriteLine(" ");
                    Console.WriteLine("Event Description: {0}", ferdi.Description);
                    Console.WriteLine(" ");
                    Console.WriteLine("Event Date and Time: {0}", ferdi.DueDate);
                    searchfound = true;
                    break;
                }
            }
            if (searchfound == false)
            {
                Console.WriteLine("SYSTEM: Event with Title: '{0}' Cannot be found.", SearchTitle);
            }
        }
    }

    public void DisplayEvent()                                          // Must display upcoming events in nearest date first
    {
        int ferdi = 1;                                                  // This is the "index" that will make it easy for the user to see position
        TheEvents = TheEvents.OrderByDescending(e => e.DueDate).ToList();         // This code sorts the list of events into nearest event first before displaying it
        foreach(Events ferdinand in TheEvents)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Event ID: #{0}", ferdinand.ID);
            Console.WriteLine(" ");
            Console.WriteLine("Event {0}. {1}", ferdi, ferdinand.Title);
            Console.WriteLine(" ");
            Console.WriteLine("Event Description: {0}", ferdinand.Description);
            Console.WriteLine(" ");
            Console.WriteLine("Event Date and Time: {0}", ferdinand.DueDate);
            ferdi++;                                                    // This increments the index for each event
        }
        if(TheEvents.Count == 0)
        {
            Console.WriteLine("SYSTEM: No events saved. ");
        }
    }

    public void RemoveEvent()
    {
        Console.WriteLine(" ");
        Console.WriteLine("SYSTEM: New Process - Removing event. ");
        Console.WriteLine(" ");
        Console.WriteLine("1. Remove with ID");
        Console.WriteLine("2. Remove with Title");
        Console.WriteLine(" ");
        Console.Write("Enter option: ");
        string option = Console.ReadLine();
        bool runmethod = true;                                          // this decides whether or not the method gets executed or not, if not it takes the user back to the main menu
        if (option != "1" && option != "2")
        {
            Console.WriteLine(" ");
            Console.WriteLine("SYSTEM: Error - Unrecognised input");
            Console.WriteLine(" ");
            runmethod = false;
        }
        if (option == "1" && runmethod == true)
        {
            Console.WriteLine(" ");
            Console.Write("Enter ID: #");
            int SearchID = Convert.ToInt32(Console.ReadLine());
            bool searchfound = false;
            int indextoberemoved = 0;
            foreach (Events ferdi in TheEvents)
            {
                if (ferdi.ID == SearchID)
                {
                    Console.WriteLine("SYSTEM: Event found. ");
                    TheEvents.RemoveAt(indextoberemoved);
                    Console.WriteLine("SYSTEM: Event Removed. ");
                    searchfound = true;
                    break;
                }
                indextoberemoved++;
            }
            if (searchfound == false)
            {
                Console.WriteLine("SYSTEM: Event with ID: '#{0}' Cannot be found.", SearchID);
            }
        }
        if (option == "2" && runmethod == true)
        {
            Console.WriteLine(" ");
            Console.Write("Enter Title: ");
            string SearchTitle = Console.ReadLine();
            bool searchfound = false;
            int indextoberemoved = 0;
            foreach (Events ferdi in TheEvents)
            {
                if (ferdi.Title == SearchTitle)
                {
                    Console.WriteLine("SYSTEM: Event found. ");
                    TheEvents.RemoveAt(indextoberemoved);
                    Console.WriteLine("SYSTEM: Event Removed. ");
                    searchfound = true;
                    break;
                }
                indextoberemoved++;
            }
            if (searchfound == false)
            {
                Console.WriteLine("SYSTEM: Event with Title: '{0}' Cannot be found.", SearchTitle);
            }
        }
    }
}
