using Avalonia.Controls;

namespace SensorAnalogico.App.Views;

public partial class ProtocoloLocalView : UserControl
{

    public TransitioningContentControl ParentContent { get => (TransitioningContentControl)this.Parent!; }
    
    public ProtocoloLocalView()
    {
        InitializeComponent();
    }

}