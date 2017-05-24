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

        public static async Task<AdcDevice> GetAdcDevice()
        {
            var controller = await GetSpiController();
            return new AdcDevice(controller);
        }

    }
}
