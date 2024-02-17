# Event-Organiser-v1.1
Version 1.1 - Now with searchable ID codes and Editable Events - An Event/To-do list organiser with a Command line user interface. Written in C# using Object Oriented Programming techniques.
<br>

Changes:
- Events can now be Edited<br>
- Events now come with ID codes<br>
- Events can be searched using their Title or ID<br>
- However, due to the nature of how the ID codes work, The number of stored Events is now only limited to 9999<br>
- More input validation<br>
- User Interface updated - line spacing and SYSTEM messages<br>
- Program finishes if any genuine error is caught e.g. (incorrect variable type entered such as Date Time)<br>

<br>
Features of this programme:
<br>
<br>
- Add an event<br>
- Edit an event<br>
- Search through stored events (With IDs or Title)<br>
- Display all stored events in closest date first<br>
- Remove an event from the stored events<br>
<br>
Currently all the events are stored in an array and will be lost when the programme is closed or the computer turns off. However there is no limit to the number of events that can be stored. Each event contains: A Title, Description, Date & Time (Time is not always necessary)

<br>
Program.cs - Is what you should run when wanting to use this code, contains the main code that calls on the other classes.<br>
Menu.cs - Contains the ASCII menu and is the main branch of this software that brings everything together and calls upon other classes.<br>
EventOrganiser.cs - Contains all the methods such as AddEvent(), RemoveEvent(), etc...<br>
Events.cs - This is the class that defines the actual properties of each event.<br>


