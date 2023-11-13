namespace ObjectBinding;

public class MessageService
{
    public string Message { get; set; }
    public string Message2 { get; set; }

    public MessageService()
    {
        Message2 = "Yelan";
        Message = "Hallo Welt";
    }
}