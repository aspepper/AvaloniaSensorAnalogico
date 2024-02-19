using Avalonia.Controls;

namespace SensorAnalogico.App.Views;

public partial class AnalogicInConfigView : UserControl
{
    public TransitioningContentControl ParentContent { get => (TransitioningContentControl)this.Parent!; }

    public AnalogicInConfigView()
    {
        InitializeComponent();
    }
}