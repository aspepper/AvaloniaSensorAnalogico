using Avalonia.Controls;
using SensorAnalogico.App.ViewModels;

namespace SensorAnalogico.App.Views;

public partial class AnalogicInView : UserControl
{

    public TransitioningContentControl ParentContent { get => (TransitioningContentControl)this.Parent!; }
    
    public AnalogicInView()
    {
        InitializeComponent();
    }

}