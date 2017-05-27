using Windows.Devices.Gpio;

namespace LinkerMezzanineCardNet.Modules
{
    public class LinkerRelay
    {
        private GpioPin _Relay;

        public LinkerRelay(ConnectorDIO connector)
        {
            _Relay = connector[0];
            _Relay.SetDriveMode(GpioPinDriveMode.Output);
        }

        public bool Relay
        {
            get
            {
                return _Relay.Read() == GpioPinValue.High;
            }
            set
            {
                _Relay.Write(value ? GpioPinValue.High : GpioPinValue.Low);
            }
        }
    }
}
