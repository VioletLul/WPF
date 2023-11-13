using System.Windows;
using System.Windows.Controls;

namespace Eigene_Routed_Events;

public class MySimpleButton : Button
{
    public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent("Tap", RoutingStrategy.Bubble,
        typeof(RoutedEventHandler), typeof(MySimpleButton));
    
    public event RoutedEventHandler Tap
    {
        add => AddHandler(TapEvent, value);
        remove => RemoveHandler(TapEvent, value);
    }

    protected override void OnClick()
    {
        RoutedEventArgs newEventArgs = new RoutedEventArgs(MySimpleButton.TapEvent);
        RaiseEvent(newEventArgs);
    }
}