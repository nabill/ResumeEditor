using ResumeEditor.BusinessLogic.Models;
using ResumeEditor.Console.Helpers;


Menus menus = new ();

bool showMenu = true;

Objects.resume = new Resume();


while (showMenu)
{
    showMenu = menus.MainMenu();
}