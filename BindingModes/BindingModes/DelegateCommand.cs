using System;
using System.Windows.Input;

namespace BindingModes;

public class DelegateCommand : ICommand
{
    public delegate void SimpleEventHandler(object sender, EventArgs e);
    private readonly SimpleEventHandler _eventHandler;

    public DelegateCommand(SimpleEventHandler eventHandler)
    {
        _eventHandler = eventHandler;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public event EventHandler? CanExecuteChanged;

    public void Execute(object? parameter)
    {
        _eventHandler(this, EventArgs.Empty);
    }
}