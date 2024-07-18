using System.Collections.Generic;

namespace TerminalBlazor.Services
{
    public class TerminalFunctions
    {
        public static void Clear(List<string> terminalLines, ref string userInput)
        {
            terminalLines.Clear();
            userInput = string.Empty;
            terminalLines.Add(string.Empty); // Add a new line
        }

        public static void Help(List<string> terminalLines, ref string userInput)
        {
            terminalLines.Add("Here is a list of the commands possible:");
            terminalLines.Add("help - prints this message");
            terminalLines.Add("clear - clears the page");
            userInput = string.Empty;
            terminalLines.Add(string.Empty); // Add a new line
        }
    }
}