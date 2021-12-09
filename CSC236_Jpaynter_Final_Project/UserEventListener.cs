using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_Jpaynter_Final_Project
{
    class UserEventListener
    {
        public LogEntries logbook;
        Core core = Core.Instance;

        public UserEventListener(LogEntries logBook)
        {
            this.logbook = logBook;
            core.UserChanged += new EventHandler(CoreUserChanged);
        }

        public void CoreUserChanged(object sender, EventArgs e)
        {
            string logEntry;

            // Write to array of log transactions
            
            for (int user = 0; user < core.getUsers().Count; user++)
            {
                logEntry = core.getUsers()[user].getName() + core.getUsers()[user].getRelationship() + core.getUsers()[user].getAge();
                logbook.EnterLog(logEntry);
                Console.WriteLine(logEntry);
            }
            logbook.EnterLog(System.DateTime.Now.ToString());
            SaveToFile(logbook);
        }

        static void SaveToFile(LogEntries logEnt)
        {
            // Map passed object to LogEntries object
            LogEntries logEntries1 = new LogEntries(); //Create with defaults
            logEntries1 = logEnt;

            // Added file parameters
            // Use Copy Path in Windows to find the file path
            const string DIR = @"C:\Users\Jonah-Laptop\source\repos\CSC236_Jpaynter_Final_Project\CSC236_Jpaynter_Final_Project\";
            const string FILENAME = DIR + "logs.txt";

            // Check Directory exists
            if (!Directory.Exists(DIR))
                Directory.CreateDirectory(DIR);

            // Get rid of old files
            if (File.Exists(FILENAME))
                File.Delete(FILENAME);

            // Open or Create the file
            FileStream outFile = new FileStream(FILENAME,
                FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            for (int idx = 0; idx < 50; ++idx)
            {
                // Write log file from an array 
                //
                string logEntry = logEntries1.logArray[idx];
                writer.WriteLine(logEntry);

                // Debugging
                Console.WriteLine("Writing to file");
                Console.WriteLine(logEntries1.logArray[idx]);

            }
            // The order of close must be writer first!!
            writer.Close();
            outFile.Close();
        }
    }
}
