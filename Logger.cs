using System;

namespace NarcityMedia.Log
{
    /// <summary>
    /// Represents a log level.
    /// The value of those colors correspond to the values of the <see cref="System.ConsoleColor"/> Enum
    /// see https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor?view=netframework-4.7.2
    /// </summary>
    public enum LogType
    {
        Success = 10,
        Warning = 14,
        Error = 12,
        Info = 11
    }

    /// <summary>
    /// Utility that allows fancy logging
    /// </summary>
    static public class Logger
    {
        /// <summary>
        /// Gets or sets the character that will separate the prefix and the logged message
        /// </summary>
        public static char Separator = '|';

        /// <summary>
        /// Logs a given message to the console without changing the current console foreground color.
        /// Additionally, prefixes the log with DateTime.Now
        /// </summary>
        /// <param name="message">The message to log to the console</param>
        public static void Log(string message)
        {
            WritePrefix();
            Console.WriteLine(message);
        }

        /// <summary>
        /// Logs a given message to the console with a color that corresponds to the given
        /// <see cref="Logger.LogType" />.
        /// Additionally, prefixes the log with DateTime.Now
        /// </summary>
        /// <param name="message">The message to log to the console</param>
        /// <param name="logType">The desired LoType.static This determines the log color</param>
        public static void Log(string message, LogType logType)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            WritePrefix();

            Console.ForegroundColor = (ConsoleColor) logType;
            Console.WriteLine(message);

            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// Writes the prefix and the separator without inserting a new line
        /// </summary>
        private static void WritePrefix()
        {
            Console.Write(String.Format("{0} {1} ", DateTime.Now.ToString("dd/mm/yyyy - HH:mm:ss"), Logger.Separator));
        }
    }
}
