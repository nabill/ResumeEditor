using ResumeEditor.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.Console.Helpers
{
    public class Input
    {

        public InputResult CaptureInput()
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            string result = "";

            while (key.Key != ConsoleKey.Escape & key.Key != ConsoleKey.Enter)
            {
                key = System.Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) return new InputResult { Exit=true, Value=""};
                else if (key.Key == ConsoleKey.Enter) return new InputResult { Exit = false, Value = result };
                else result = result + key.KeyChar.ToString();
            }
            return new InputResult { Exit = false, Value = result };
        }
    }
}
