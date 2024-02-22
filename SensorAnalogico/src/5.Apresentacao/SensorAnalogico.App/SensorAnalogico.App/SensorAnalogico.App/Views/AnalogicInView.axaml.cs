using Avalonia.Controls;

namespace SensorAnalogico.App.Views;

public partial class AnalogicInView : UserControl
{

    public TransitioningContentControl ParentContent { get => (TransitioningContentControl)this.Parent!; }
    
    public AnalogicInView()
    {
        InitializeComponent();
    }

}