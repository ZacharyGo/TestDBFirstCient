using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TestDBFirstCient
{
    public static class TGZZZLog
    {
        public static void StartLog()
        {
            Console.WriteLine("Start Log");

        }

        public static void WriteLogFile_ERR(string message, string sessionID, string memberID, Exception e)
        {
            Console.WriteLine("WriteLogFile_ERR message: {0}, sessionID : {1}, memberID: {2}, ", message, sessionID, memberID, e.Message);
        }

        public static void WriteEventLog_ERR(string message)
        {
            Console.WriteLine("WriteEventLog_ERR message: {0}", message);

        }

        public static void EndLog()
        {
            Console.WriteLine("End Log");

        }

        public static void ZacLog(string message)
        {
            Console.WriteLine(message);
        }

    }
}
