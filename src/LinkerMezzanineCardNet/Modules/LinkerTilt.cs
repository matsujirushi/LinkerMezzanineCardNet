using Windows.Devices.Gpio;

namespace LinkerMezzanineCardNet.Modules
{
    public class LinkerTilt
    {
        private GpioPin _Tilt;

        public LinkerTilt(ConnectorDIO connector)
        {
            _Tilt = connector[0];
            _Tilt.SetDriveMode(GpioPinDriveMode.Input);
        }

        public bool Tilt
        {
            get
            {
                return _Tilt.Read() == GpioPinValue.High;
            }
        }
    }
}
