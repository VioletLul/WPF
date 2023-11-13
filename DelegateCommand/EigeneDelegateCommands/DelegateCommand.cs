using System;
using System.Windows.Input;

namespace EigeneDelegateCommands;

public class DelegateCommand : ICommand
{

    // public delegate void SimpleEventHandler(object sender, EventArgs e);
    //
    // private SimpleEventHandler _eventHandler;

    private Action<MessageService> _eventHandler;
    
    
    public DelegateCommand(Action<MessageService> handler)
    {
        _eventHandler = handler;
    }
    
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        _eventHandler(new MessageService());
    }

    public event EventHandler? CanExecuteChanged;
}