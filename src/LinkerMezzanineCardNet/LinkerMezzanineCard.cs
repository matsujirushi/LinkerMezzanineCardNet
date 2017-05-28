using System;
using System.Threading.Tasks;
using Windows.Devices.Spi;

namespace LinkerMezzanineCardNet
{
    public static class LinkerMezzanineCard
    {
        private static SpiController _SpiController = null;

        private static async Task<SpiController> GetSpiController()
        {
            return _SpiController ?? (_SpiController = await SpiController.GetDefaultAsync());
        }

        public static ConnectorDIO GetConnectorD1()
        {
            return new ConnectorDIO(ConnectorPinName.D_A, ConnectorPinName.D_B);
        }

        public static ConnectorDIO GetConnectorD2()
        {
            return new ConnectorDIO(ConnectorPinName.D_C, ConnectorPinName.D_D);
        }

        public static ConnectorDIO GetConnectorD3()
        {
            return new ConnectorDIO(ConnectorPinName.D_E, ConnectorPinName.D_J);
        }

        public static ConnectorDIO GetConnectorD4()
        {
            return new ConnectorDIO(ConnectorPinName.D_G, ConnectorPinName.D_H);
        }
    }
}
