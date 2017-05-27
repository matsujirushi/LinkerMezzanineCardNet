using Windows.Devices.Gpio;

namespace LinkerMezzanineCardNet
{
    public class ConnectorDIO
    {
        private GpioPin[] _Pins;

        public GpioPin this[int index]
        {
            get
            {
                return _Pins[index];
            }
        }

        internal ConnectorDIO(ConnectorPinName pin0, ConnectorPinName pin1)
        {
            var controller = GpioController.GetDefault();
            _Pins = new GpioPin[2];
            _Pins[0] = controller.OpenPin((int)pin0);
            _Pins[1] = controller.OpenPin((int)pin1);
        }
    }
}
