using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWraith.Utilities
{
    internal class Logger
    {
        private static readonly string LogFilePath = "error.log";

        public static void LogException(Exception ex)
        {
            try
            {
                using (var writer = new StreamWriter(LogFilePath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}]");
                    writer.WriteLine($"Exception Type: {ex.GetType().FullName}");
                    writer.WriteLine($"Message: {ex.Message}");
                    writer.WriteLine($"StackTrace:\n{ex.StackTrace}");
                    writer.WriteLine(new string('-', 40));
                }
            }
            catch (Exception)
            {
                // Handle any exceptions that may occur during logging
                // to prevent an infinite loop of exceptions.
            }
        }
    }
}
