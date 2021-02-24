using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class EventLogWorking
    {
        public static string message;

        public static void WriteEventLog(string message)
        {
            System.Diagnostics.EventLog appLog = new System.Diagnostics.EventLog();
            appLog.Source = "Parking";
            appLog.WriteEntry(message);
        }
        public static void InformationEventLog()
        {

            WriteEventLog(message);

        }
    }
}
