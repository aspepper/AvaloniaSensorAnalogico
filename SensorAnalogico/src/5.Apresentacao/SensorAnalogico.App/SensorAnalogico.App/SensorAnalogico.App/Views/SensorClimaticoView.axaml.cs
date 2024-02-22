using Avalonia.Controls;

namespace SensorAnalogico.App.Views
{

    public partial class SensorClimaticoView : UserControl
    {

        public TransitioningContentControl ParentContent { get => (TransitioningContentControl)this.Parent!; }

        public SensorClimaticoView()
        {
            InitializeComponent();
        }
    }
}