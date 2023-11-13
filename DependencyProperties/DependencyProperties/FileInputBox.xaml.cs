using System.Reflection.Metadata.Ecma335;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace DependencyProperties;

public partial class FileInputBox : UserControl
{

    public static readonly DependencyProperty FileNameProperty =
        DependencyProperty.Register(nameof(FileName), typeof(string), typeof(FileInputBox), new UIPropertyMetadata(string.Empty, TextChangedCallback));

    private static void TextChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        FileInputBox fileInputBox = (FileInputBox)d;
        fileInputBox.TxtFileName.Text = e.NewValue as string;
    }

    public string FileName
    {
        get => (string)GetValue(FileNameProperty);
        set => SetValue(FileNameProperty, value);
    }

    public FileInputBox()
    {
        InitializeComponent();
    }

    private void BtnSelectFile_OnClick(object sender, RoutedEventArgs e)
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        if (fileDialog.ShowDialog() != false)
        {
            FileName = fileDialog.FileName;
        }
    }
}