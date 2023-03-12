using ResumeEditor.BusinessLogic.Enums;
using ResumeEditor.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.Console.Helpers
{
    public class GeneralInformations
    {
        public void Menu()
        {
            Menus menus = new();
            Write write = new();
            Input input = new();

            bool end = false;
            int field = 0;
            
            InputResult inputResult = new InputResult();

            menus.ApplicationTitle();
            menus.BackToMainMenu();

            do
            {
                switch (field)
                {
                    case 0:
                        write.Text("Fullname : ", MessageType.Accent);
                        System.Console.SetCursorPosition(11, System.Console.CursorTop);
                        write.Text(Objects.resume.Fullname, MessageType.Highlight);
                        System.Console.SetCursorPosition(11, System.Console.CursorTop);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") Objects.resume.Fullname = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 1:
                        write.Text("Address : ", MessageType.Accent);
                        System.Console.SetCursorPosition(10, System.Console.CursorTop);
                        write.Text(Objects.resume.Address, MessageType.Highlight);
                        System.Console.SetCursorPosition(10, System.Console.CursorTop);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") Objects.resume.Address = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 2:
                        write.Text("Phone : ", MessageType.Accent);
                        System.Console.SetCursorPosition(8, System.Console.CursorTop);
                        write.Text(Objects.resume.Phone, MessageType.Highlight);
                        System.Console.SetCursorPosition(8, System.Console.CursorTop);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") Objects.resume.Phone = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 3:
                        write.Text("Email : ", MessageType.Accent);
                        System.Console.SetCursorPosition(8, System.Console.CursorTop);
                        write.Text(Objects.resume.Email, MessageType.Highlight);
                        System.Console.SetCursorPosition(8, System.Console.CursorTop);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") Objects.resume.Email = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    default:
                        end = true;
                        break;
                }
                field++;
            }
            while (end == false);

            menus.MainMenu();
        }


    }
}
