using System;
using System.ComponentModel;

namespace BindingModes;

public class MessageService : INotifyPropertyChanged
{
    private string? _message;
    public string? Message
    {
        get => _message;
        set
        {
            _message = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Message)));
        }
    }
    public DelegateCommand StartMessageService { get; set; }

    public MessageService()
    {
        StartMessageService = new DelegateCommand(StartService);
    }

    private void StartService(object sender, EventArgs e)
    {
        Message = "Yelan uwu";
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}