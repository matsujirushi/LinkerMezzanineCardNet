using Windows.Devices.Gpio;

namespace LinkerMezzanineCardNet.Modules
{
    public class LinkerButton
    {
        private GpioPin _Button;

        public LinkerButton(ConnectorDIO connector)
        {
            _Button = connector[0];
            _Button.SetDriveMode(GpioPinDriveMode.Input);
        }

        public bool Button
        {
            get
            {
                return _Button.Read() == GpioPinValue.Low;
            }
        }
    }
}
