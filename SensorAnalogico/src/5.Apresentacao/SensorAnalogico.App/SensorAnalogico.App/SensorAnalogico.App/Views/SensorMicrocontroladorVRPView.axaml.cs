using Avalonia.Controls;

namespace SensorAnalogico.App.Views
{

    public partial class SensorMicrocontroladorVRPView : UserControl
    {

        public TransitioningContentControl ParentContent { get => (TransitioningContentControl)this.Parent!; }

        public SensorMicrocontroladorVRPView()
        {
            InitializeComponent();
        }
    }
}