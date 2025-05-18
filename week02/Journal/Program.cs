//My Beyond Requirements was creating a way to create a new Journal File where the user could upload entries.

using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("");
        string answer = "0";
        // string filename = "myFile.txt";

        Journal entry1 = new Journal();


        do
        {
            Console.WriteLine("Please Select an option: ");
            Console.WriteLine("1. Write New Entry ");
            Console.WriteLine("2. Display Journal Entries ");
            Console.WriteLine("3. Save to Journal File ");
            Console.WriteLine("4. Load existing Journal File");
            Console.WriteLine("5. Create new Journal File ");
            Console.WriteLine("0. Quit ");
            answer = Console.ReadLine();


            if (answer == "1")
            {
                entry1.AddEntry();

            }
            if (answer == "2")
            {

                entry1.DisplayAllEntries();
            }
            if (answer == "3")
            {
                entry1.SaveEntry();
            }
            if (answer == "4")
            {
                entry1.LoadEntry();
            }
            if (answer == "5")
            {
                Console.WriteLine("Name your new Journal File: ");
                string fileName = Console.ReadLine();
                string path = Path.Combine(Environment.CurrentDirectory, fileName);
                // @"C:\Journal";
                File.WriteAllText(path, fileName);

                Console.WriteLine($"Congradulations! Your file, {fileName} was created. Please select 'Save' to begin saving your entries into this new file.");

            }

        } while (answer != "0");



    }


}



//Collect entry
    //SHOW USER RANDOM PROMPT - 5 different promtps - select randomly from prompts we have written
    //Save their response
    //Save the date as an entry



//Iterate through all entries on the journal and display them on the screen
    // Maybe a feature to display only a certain date on a journal?


//Save the entire Journal into a file
    //Get file name

//Load a journal from a file
    //When they update the entries it will replace them

// PRovide a menu that allows the options to do each item

//

