namespace LinkerMezzanineCardNet
{
    public class ConnectorADC
    {
        public enum PinName
        {
            A0 = 0,
            A1 = 1,
            A2 = 2,
            A3 = 3,
        }

        private int[] _PinChannels;

        public double this[int index]
        {
            get
            {
                return LinkerMezzanineCard.GetAdcDevice().Read(_PinChannels[index]);
            }
        }

        internal ConnectorADC(PinName pin0, PinName pin1)
        {
            _PinChannels = new int[2];
            _PinChannels[0] = (int)pin0;
            _PinChannels[1] = (int)pin1;
        }
    }
}
