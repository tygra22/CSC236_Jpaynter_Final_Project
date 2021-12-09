using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_Jpaynter_Final_Project
{
    class StatusEventListener
    {
        public LogEntries logbook;
        Core core = Core.Instance;

        public StatusEventListener(LogEntries logBook)
        {
            core.StatusChanged += new EventHandler(CoreStatusChanged);
        }

        public void CoreStatusChanged(object sender, EventArgs e)
        {
            string DELIM = ",";
            string logEntry;

            
        }
    }
}
