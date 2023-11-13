using System.Windows.Input;

namespace Commands;

public class MyCommand
{
    private static RoutedUICommand launch_command;

    static MyCommand()
    {
        launch_command = new RoutedUICommand("My launch command", "Launch", typeof(MyCommand));
        Launch.InputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
    }

    public static RoutedUICommand Launch
    {
        get
        {
            return launch_command;
        }
    }
}