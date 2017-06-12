using Windows.Devices.Gpio;

namespace LinkerMezzanineCardNet
{
    public class ConnectorDIO
    {
        public enum PinName
        {
            D_A = DragonBoard410c.PinName.J8_23,
            D_B = DragonBoard410c.PinName.J8_24,
            D_C = DragonBoard410c.PinName.J8_25,
            D_D = DragonBoard410c.PinName.J8_26,
            D_E = DragonBoard410c.PinName.J8_27,
            D_J = DragonBoard410c.PinName.J8_32,
            /// <summary>
            /// Input only
            /// </summary>
            D_G = DragonBoard410c.PinName.J8_29,
            D_H = DragonBoard410c.PinName.J8_30,
        }

        private GpioPin[] _Pins;

        public GpioPin this[int index]
        {
            get
            {
                return _Pins[index];
            }
        }

        internal ConnectorDIO(PinName pin0, PinName pin1)
        {
            var controller = GpioController.GetDefault();
            _Pins = new GpioPin[2];
            _Pins[0] = controller.OpenPin((int)pin0);
            _Pins[1] = controller.OpenPin((int)pin1);
        }
    }
}
