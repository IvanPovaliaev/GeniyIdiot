namespace GeniyIdiotConsoleApp.Menu
{
    public class UserChangeOption : MenuOption
    {
        public UserChangeOption()
        {
            Description = "Сменить пользователя";
            Option = () => ConsoleManager.CreateUser();
        }
    }
}
