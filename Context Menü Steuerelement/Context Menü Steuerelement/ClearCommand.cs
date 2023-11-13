using System;
using System.Windows.Input;

namespace Context_Menü_Steuerelement;

public class ClearCommand : ICommand
{

    public delegate void SimpleeventHandler(object sender, EventArgs e);

    private SimpleeventHandler _eventHandler;

    public ClearCommand(SimpleeventHandler handler)
    {
        _eventHandler = handler;
    }
    
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        _eventHandler(this, new EventArgs());
    }

    public event EventHandler? CanExecuteChanged;
}