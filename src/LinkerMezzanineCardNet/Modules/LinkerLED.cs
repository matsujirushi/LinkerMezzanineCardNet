using Windows.Devices.Gpio;

namespace LinkerMezzanineCardNet.Modules
{
    public class LinkerLED
    {
        private GpioPin _Led;

        public LinkerLED(ConnectorDIO connector)
        {
            _Led = connector[0];
            _Led.SetDriveMode(GpioPinDriveMode.Output);
        }

        public bool Led
        {
            get
            {
                return _Led.Read() == GpioPinValue.High;
            }
            set
            {
                _Led.Write(value ? GpioPinValue.High : GpioPinValue.Low);
            }
        }
    }
}
