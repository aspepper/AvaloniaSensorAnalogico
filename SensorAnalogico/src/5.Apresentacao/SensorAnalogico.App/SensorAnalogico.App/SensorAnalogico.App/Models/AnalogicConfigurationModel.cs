namespace SensorAnalogico.App.Models
{
    public class AnalogicConfigurationModel
    {
        public AnalogicConfigurationModel() { }

        public double GeneralStatus { get; set; } = 0;
        public double CommandStatus { get; set; } = 0;
        public int CommandType { get; set; } = 0;
        public string IdController { get; set; } = "0";
        public string IdComponent { get; set; } = "0";

        public int Calibration1 { get; set; } = 0;
        public int Calibration2 { get; set; } = 0;
        public int Calibration3 { get; set; } = 0;
        public int Calibration4 { get; set; } = 0;
        public int Calibration5 { get; set; } = 0;
        public int Calibration6 { get; set; } = 0;
        public int CalibrationPoints { get; set; } = 0;
        public int Value1 { get; set; } = 0;
        public int Value2 { get; set; } = 0;
        public int Value3 { get; set; } = 0;
        public int Value4 { get; set; } = 0;
        public int Value5 { get; set; } = 0;
        public int Value6 { get; set; } = 0;
    }
}
