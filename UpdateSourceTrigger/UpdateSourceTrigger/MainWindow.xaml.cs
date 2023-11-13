using System;
using System.Windows;
using System.Windows.Controls;

namespace UpdateSourceTrigger;

/// <summary>
/// Interaktionslogik für MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        var bindingExpression = TbTest.GetBindingExpression(TextBox.TextProperty) ?? throw new InvalidOperationException();
        bindingExpression.UpdateSource();
    }
}