using ResumeEditor.BusinessLogic.Enums;

namespace ResumeEditor.Console.Helpers
{
    public class DisplayResume
    {
        public void Content()
        {
            Menus menus = new();
            Write write = new();
            
            menus.ApplicationTitle();

            System.Console.WriteLine();
            write.Line(" GENERAL INFORMATION", MessageType.Accent);
            System.Console.WriteLine();

            write.Text(" Fullname : ", MessageType.Highlight);
            write.Line(Objects.resume.Fullname, MessageType.Normal);
            write.Text(" Adress : ", MessageType.Highlight);
            write.Line(Objects.resume.Address, MessageType.Normal);
            write.Text(" Phone : ", MessageType.Highlight);
            write.Line(Objects.resume.Phone, MessageType.Normal);
            write.Text(" Email : ", MessageType.Highlight);
            write.Line(Objects.resume.Email, MessageType.Normal);


            System.Console.WriteLine();
            write.Line(" EXPERIENCE", MessageType.Accent);
            System.Console.WriteLine();

            if (Objects.resume.Experiences.Count==0)
            {
                write.Text(" No content", MessageType.Warning);
            }
            else 
            {
                foreach (var experience in Objects.resume.Experiences)
                {
                    write.Text(" * "+experience.Company, MessageType.Normal);
                    write.Line($" ({experience.Start}-{experience.End})", MessageType.Highlight);
                    write.Line("   " + experience.Title, MessageType.Normal);
                    System.Console.WriteLine();
                }
            }

            System.Console.WriteLine();
            write.Line(" STUDIES", MessageType.Accent);
            System.Console.WriteLine();

            // TODO : Complete this part once the menu is implemented

            write.Text(" Developpement in progress", MessageType.Warning);
            System.Console.WriteLine();



            System.Console.WriteLine();
            write.Line(" LANGUAGES", MessageType.Accent);
            System.Console.WriteLine();

            // TODO : Complete this part once the menu is implemented

            write.Text(" Developpement in progress", MessageType.Warning);
            System.Console.WriteLine();



            System.Console.ReadKey();
        }
    }
}
