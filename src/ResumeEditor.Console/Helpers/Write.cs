using ResumeEditor.BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.Console.Helpers
{
    public class Write
    {
        public void Text(string message, MessageType type)
        {
            System.Console.BackgroundColor = ConsoleColor.Black;
            switch (type)
            {
                case MessageType.Title:
                    System.Console.BackgroundColor = ConsoleColor.DarkCyan;
                    System.Console.ForegroundColor = ConsoleColor.White;
                    break;
                case MessageType.Normal:
                    System.Console.ForegroundColor = ConsoleColor.White;
                    break;
                case MessageType.Highlight:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case MessageType.Success:
                    System.Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case MessageType.Warning:
                    System.Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case MessageType.Error:
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case MessageType.Accent:
                    System.Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                default:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
            System.Console.Write(message);
            System.Console.BackgroundColor = ConsoleColor.Black;
            System.Console.ForegroundColor = ConsoleColor.White;
        }

        public void Line(string message, MessageType type)
        {
            Text(message, type);
            System.Console.WriteLine("");
        }
    }
}
