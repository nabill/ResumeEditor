using Microsoft.VisualBasic.FileIO;
using ResumeEditor.BusinessLogic.Enums;
using ResumeEditor.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.Console.Helpers
{
    public class ExperienceMenu
    {
        public void ShowMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = OptionsMenu();
            } 
        }

        private List<ExperienceMenuOption> options;
        private bool OptionsMenu()
        {
            Menus menus = new();
            Write write = new();
            GeneralInformations generalInformations = new();
            int option = 1;
            options = new();

            menus.ApplicationTitle();
            menus.BackToMainMenu();

            System.Console.WriteLine();

            write.Line("EXPERIENCE :", MessageType.Normal);
            write.Line("------------", MessageType.Normal);

            System.Console.WriteLine();

            write.Text(" 1 ", MessageType.Title);
            System.Console.WriteLine(" New experience");

            foreach (var experience in Objects.resume.Experiences)
            {
                option++;
                options.Add( new ExperienceMenuOption {  
                    OptionKey = option.ToString(),
                    Operation = RecordOperation.Edit,
                    ExperienceId = experience.Id
                });
                write.Text(" " + option.ToString() + " ", MessageType.Title);
                write.Text(" EDIT   ", MessageType.Warning);
                System.Console.WriteLine($"{experience.Company} ({experience.Start}-{experience.End})");
                option++;
                options.Add(new ExperienceMenuOption
                {
                    OptionKey = option.ToString(),
                    Operation = RecordOperation.Delete,
                    ExperienceId = experience.Id
                });
                write.Text(" " + option.ToString() + " ", MessageType.Title);
                write.Text(" DELETE ", MessageType.Error);
                System.Console.WriteLine($"{experience.Company} ({experience.Start}-{experience.End})");
            }

            System.Console.WriteLine();

            write.Text("Select an option from the list : ", MessageType.Normal);

            var Choice = System.Console.ReadKey();

            switch (Choice.KeyChar.ToString())
            {
                case "1":
                    AddExperience();
                    return false;
                default:
                    ExperienceMenuOption experienceMenuOption = options.FirstOrDefault(x => x.OptionKey == Choice.KeyChar.ToString());
                    if (experienceMenuOption != null)
                    {
                        if (experienceMenuOption.Operation == RecordOperation.Edit) EditExperience(experienceMenuOption.ExperienceId);
                        else DeleteExperience(experienceMenuOption.ExperienceId);
                        return false;
                    }
                    return true;
                    //System.Console.WriteLine(">>>>>>>>>>>>>>");
                    //System.Console.WriteLine(Choice.KeyChar.ToString());
                    //System.Console.ReadKey();
                    ////// Delete or Edit
                    ////int SelectedOption;
                    ////if (int.TryParse(Choice.KeyChar.ToString(), out SelectedOption))
                    ////{

                    ////}
                    ////System.Console.WriteLine(Choice.KeyChar.ToString());
                    //return true;
            }
        }

        
        public void AddExperience()
        {
            Menus menus = new();
            Write write = new();
            Input input = new();

            bool end = false;
            int field = 0;

            InputResult inputResult = new InputResult();

            menus.ApplicationTitle();
            menus.BackToMainMenu();

            Experience experience = new Experience();
            

            do
            {
                switch (field)
                {
                    case 0:
                        write.Text("Company : ", MessageType.Accent);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") experience.Company = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 1:
                        write.Text("Start Date : ", MessageType.Accent);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") experience.Start = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 2:
                        write.Text("End Date : ", MessageType.Accent);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") experience.End = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 3:
                        write.Text("Job title : ", MessageType.Accent);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") experience.Title = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    default:
                        Objects.resume.Experiences.Add(experience);
                        end = true;
                        break;
                }
                field++;
            }
            while (end == false);

            menus.MainMenu();
        }

        public void EditExperience(Guid experienceId)
        {
            Menus menus = new();
            Write write = new();
            Input input = new();

            bool end = false;
            int field = 0;

            InputResult inputResult = new InputResult();

            menus.ApplicationTitle();
            menus.BackToMainMenu();

            Experience experience = Objects.resume.Experiences.FirstOrDefault(x => x.Id == experienceId);

            do
            {
                switch (field)
                {
                    case 0:
                        write.Text("Company : ", MessageType.Accent);
                        System.Console.SetCursorPosition(10, System.Console.CursorTop);
                        write.Text(experience.Company, MessageType.Highlight);
                        System.Console.SetCursorPosition(10, System.Console.CursorTop);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") experience.Company = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 1:
                        write.Text("Start date : ", MessageType.Accent);
                        System.Console.SetCursorPosition(13, System.Console.CursorTop);
                        write.Text(experience.Start, MessageType.Highlight);
                        System.Console.SetCursorPosition(13, System.Console.CursorTop);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") experience.Start = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 2:
                        write.Text("End date : ", MessageType.Accent);
                        System.Console.SetCursorPosition(11, System.Console.CursorTop);
                        write.Text(experience.End, MessageType.Highlight);
                        System.Console.SetCursorPosition(11, System.Console.CursorTop);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") experience.End = inputResult.Value;
                        }
                        end = inputResult.Exit;
                        System.Console.WriteLine();
                        break;
                    case 3:
                        write.Text("Job title : ", MessageType.Accent);
                        System.Console.SetCursorPosition(12, System.Console.CursorTop);
                        write.Text(experience.Title, MessageType.Highlight);
                        System.Console.SetCursorPosition(12, System.Console.CursorTop);
                        inputResult = input.CaptureInput();
                        if (!inputResult.Exit)
                        {
                            if (inputResult.Value != "") experience.Title = inputResult.Value;
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

        public void DeleteExperience(Guid experienceId)
        {
            Experience experience = Objects.resume.Experiences.FirstOrDefault(x => x.Id == experienceId);
            Objects.resume.Experiences.Remove(experience);
        }

    }
}
