using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Diagnostics.EventLog;
using System.IO;
using System.Diagnostics;

namespace EventLogApp
{
   public class Test
{
    public static void Main()
    {
        // check for the event log source on specified machine
        // the Application event log source on MCBcomputer
        if (!EventLog.Exists("Application", "FTFL"))
        {
            Console.WriteLine("The log does not exist!");
            return;
        }

        EventLog myLog = new EventLog();
        myLog.Log = "Application";
        myLog.MachineName = "FTFL";
        Console.WriteLine("There are " + myLog.Entries.Count + " entr[y|ies] in the Application log:");

        foreach (EventLogEntry entry in myLog.Entries)
        {
            Console.WriteLine("\tEntry: " + entry.Message);
        }

        // check for Demo event log source existence
        // create it if it not exist

        if (!EventLog.SourceExists("Demo"))
        {
            EventLog.CreateEventSource("Demo", "Demo");
        }

        EventLog.WriteEntry("AnySource", "writing error to demo log.", EventLogEntryType.Error);
        Console.WriteLine("Monitoring of Application event log began...");
        Console.WriteLine(@"Press 'q' and 'Enter' to quit");

        while (Console.Read() != 'q')
        {
            // Now we will monitor the new entries that will be written.
            // When you create an EntryWrittenEventHandler delegate
            // you identify the method that will handle the event.
            myLog.EntryWritten += new EntryWrittenEventHandler(OnEntryWritten);

            // EnableRaisingEvents gets or sets a value indicating whether the
            // EventLog instance receives EntryWritten event notifications.
            myLog.EnableRaisingEvents = true;
        }
    }

    public static void OnEntryWritten(Object source, EntryWrittenEventArgs e)
    {
        Console.WriteLine("written entry: " + e.Entry.Message);
    }
}
}