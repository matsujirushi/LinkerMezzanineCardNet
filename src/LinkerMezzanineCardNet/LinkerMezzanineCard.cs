using System;
using System.Threading.Tasks;
using Windows.Devices.Spi;

namespace LinkerMezzanineCardNet
{
    public static class LinkerMezzanineCard
    {
        private static AdcDevice _AdcDevice = null;

        internal static AdcDevice GetAdcDevice()
        {
            return _AdcDevice ?? (_AdcDevice = new AdcDevice());
        }

        public static ConnectorDIO GetConnectorD1()
        {
            return new ConnectorDIO(ConnectorDIO.PinName.D_A, ConnectorDIO.PinName.D_B);
        }

        public static ConnectorDIO GetConnectorD2()
        {
            return new ConnectorDIO(ConnectorDIO.PinName.D_C, ConnectorDIO.PinName.D_D);
        }

        public static ConnectorDIO GetConnectorD3()
        {
            return new ConnectorDIO(ConnectorDIO.PinName.D_E, ConnectorDIO.PinName.D_J);
        }

        public static ConnectorDIO GetConnectorD4()
        {
            return new ConnectorDIO(ConnectorDIO.PinName.D_G, ConnectorDIO.PinName.D_H);
        }
    }
}
