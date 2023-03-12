using ResumeEditor.BusinessLogic.Enums;
using ResumeEditor.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.Console.Helpers
{
    public class Menus
    {   
        public void ApplicationTitle()
        {
            System.Console.BackgroundColor = ConsoleColor.Black;
            System.Console.Clear();
            System.Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.SetCursorPosition(0, 1);
            System.Console.WriteLine(" RESUME EDITOR ");
            System.Console.BackgroundColor = ConsoleColor.Black;
        }

        public void BackToMainMenu()
        {
            System.Console.BackgroundColor = ConsoleColor.Black;
            System.Console.ForegroundColor = ConsoleColor.DarkGray;
            System.Console.SetCursorPosition(90, 1);
            System.Console.Write("Press ");
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.SetCursorPosition(96, 1);
            System.Console.Write("ESC");
            System.Console.ForegroundColor = ConsoleColor.DarkGray;
            System.Console.SetCursorPosition(100, 1);
            System.Console.Write("to go on main menu ");
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.SetCursorPosition(0, 3);
        }


        public bool MainMenu()
        {
            Write write = new();
            GeneralInformations generalInformations = new();
            ExperienceMenu experience = new();
            DisplayResume displayResume = new();
            Export export = new();

            ApplicationTitle();

            System.Console.WriteLine();

            write.Text(" 1 ", MessageType.Title);
            write.Line(" General informations", MessageType.Normal);

            write.Text(" 2 ", MessageType.Title);
            write.Line(" Experience", MessageType.Normal);
            
            write.Text(" 3 ", MessageType.Highlight);
            write.Text(" Studies", MessageType.Normal);
            write.Line(" (Not implemented yet)", MessageType.Highlight);

            write.Text(" 4 ", MessageType.Highlight);
            write.Text(" Languages", MessageType.Normal);
            write.Line(" (Not implemented yet)", MessageType.Highlight);

            write.Text(" 5 ", MessageType.Title);
            write.Line(" Display resume", MessageType.Normal);

            write.Text(" 6 ", MessageType.Title);
            write.Line(" Export to PDF", MessageType.Normal);

            write.Text(" 7 ", MessageType.Title);
            write.Line(" Exit", MessageType.Normal);

            System.Console.WriteLine();

            write.Text("Select an option from the list : ", MessageType.Normal);

            var Choice = System.Console.ReadKey();

            switch (Choice.KeyChar.ToString())
            {
                case "1":
                    generalInformations.Menu();
                    return true;
                case "2":
                    experience.ShowMenu();
                    return true;

                // TODO: Menus for studies and languages sections

                case "5":
                    displayResume.Content();
                    return true;
                case "6":
                    export.GeneratePDF();
                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }


    }
}
