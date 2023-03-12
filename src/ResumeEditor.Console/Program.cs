using ResumeEditor.BusinessLogic.Models;
using ResumeEditor.Console.Helpers;


Menus menus = new ();


bool showMenu = true;

Objects.resume = new Resume();
Objects.resume.Experiences.Add(new ResumeEditor.BusinessLogic.Models.Experience()
{
    Title = ".Net Developper",
    Company = "Computershare",
    Start = "01/2023",
    End = "Today"
});
Objects.resume.Experiences.Add(new ResumeEditor.BusinessLogic.Models.Experience()
{
    Title = ".Net Developper",
    Company = "Computershare",
    Start = "01/2023",
    End = "Today"
});
// TODO: Get resume data from source file if any


while (showMenu)
{
    showMenu = menus.MainMenu();
}