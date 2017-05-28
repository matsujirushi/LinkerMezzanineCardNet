using Windows.Devices.Gpio;

namespace LinkerMezzanineCardNet.Modules
{
    public class LinkerTouchSensor
    {
        private GpioPin _Touch;

        public LinkerTouchSensor(ConnectorDIO connector)
        {
            _Touch = connector[0];
            _Touch.SetDriveMode(GpioPinDriveMode.Input);
        }

        public bool Touch
        {
            get
            {
                return _Touch.Read() == GpioPinValue.High;
            }
        }
    }
}
