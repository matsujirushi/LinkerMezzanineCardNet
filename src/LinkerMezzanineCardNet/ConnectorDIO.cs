using Windows.Devices.Gpio;

namespace LinkerMezzanineCardNet
{
    public class ConnectorDIO
    {
        private GpioPin _Pin0;
        public GpioPin Pin0 { get { return _Pin0; } }

        private GpioPin _Pin1;
        public GpioPin Pin1 { get { return _Pin1; } }

        internal ConnectorDIO(ConnectorPinName pin0, ConnectorPinName pin1)
        {
            var controller = GpioController.GetDefault();
            _Pin0 = controller.OpenPin((int)pin0);
            _Pin1 = controller.OpenPin((int)pin1);
        }
    }
}
