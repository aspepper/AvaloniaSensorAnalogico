using Avalonia.Controls;

namespace SensorAnalogico.App.Views;

public partial class ComponentView : UserControl
{
    public TransitioningContentControl ParentContent { get => (TransitioningContentControl)this.Parent!; }
    
    public ComponentView()
    {
        InitializeComponent();
    }
}