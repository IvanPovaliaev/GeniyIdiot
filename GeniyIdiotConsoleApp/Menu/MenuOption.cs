using System;

namespace GeniyIdiotConsoleApp.Menu
{
    public class MenuOption
    {
        public string Description { get; protected set; }
        public Action Option { get; protected set; }
    }
}
