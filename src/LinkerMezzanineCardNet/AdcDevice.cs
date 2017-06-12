using System;
using Windows.Devices.Spi;

namespace LinkerMezzanineCardNet
{
    internal class AdcDevice : IDisposable
    {
        private SpiDevice _Device;

        public AdcDevice()
        {
            var asyncOperation = SpiController.GetDefaultAsync();

            var settings = new SpiConnectionSettings(0);
            settings.ClockFrequency = 112500;
            settings.Mode = SpiMode.Mode0;

            var controller = asyncOperation.GetResults();

            _Device = controller.GetDevice(settings);
        }

        public void Dispose()
        {
            _Device?.Dispose();
        }

        public double Read(int channel)
        {
            if (channel < 0 || 4 <= channel) throw new ArgumentOutOfRangeException(nameof(channel));

            var buffer = new byte[3];
            _Device.TransferFullDuplex(new byte[3] { 0x01, (byte)(0x80 | channel << 4), 0x00 }, buffer);
            var value = (buffer[1] & 0x03) << 8 | buffer[2];

            return (double)value / 1024;
        }
    }
}
