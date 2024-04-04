using Avalonia.Controls;

namespace SensorAnalogico.App.Views;

public partial class AnalogicInView : UserControl
{

    public TransitioningContentControl ParentContent { get => (TransitioningContentControl)this.Parent!; }
    
    public AnalogicInView()
    {
        InitializeComponent();
    }

    private void ButtonGetInfo_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        PopUpExemplo.IsVisible = !PopUpExemplo.IsVisible;
    }

    public void ShowPopup()
    {
        PopUpExemplo.IsVisible = true;
    }

    public void HidePopup()
    {
        PopUpExemplo.IsVisible = false;
    }

}