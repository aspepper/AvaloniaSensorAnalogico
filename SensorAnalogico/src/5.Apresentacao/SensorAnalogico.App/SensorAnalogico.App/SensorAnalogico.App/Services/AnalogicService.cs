using SensorAnalogico.App.Models;

namespace SensorAnalogico.App.Services
{
    public class AnalogicService
    {
        public AnalogicConfigurationModel ConfigurationData { get; set; } = new()
        {
            GeneralStatus = 0.5,
            CommandStatus = 0.5,
            CommandType = 0,
            IdController = "0",
            IdComponent = "0",
            Calibration1 = 0,
            Calibration2 = 0,
            Calibration3 = 0,
            Calibration4 = 0,
            Calibration5 = 0,
            Calibration6 = 0,
            CalibrationPoints = 0,
            Value1 = 0,
            Value2 = 0,
            Value3 = 0,
            Value4 = 0,
            Value5 = 0,
            Value6 = 0,
        };
    }
}
