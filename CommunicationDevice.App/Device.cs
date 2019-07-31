namespace CommunicationDevice.App
{
    public interface IDevice
    {

    }
    public class Call : IDevice
    {
        private ICall _callDevice;

        public Call(ICall callDevice)
        {
            _callDevice = callDevice;
        }

        public string MakeCall(string phoneNumber)
        {
            return _callDevice.MakeCall(phoneNumber);
        }
    }

    public class TextMessage : IDevice
    {
        private ITextMessage _messageDevice;

        public TextMessage(ITextMessage messageDevice)
        {
            _messageDevice = messageDevice;
        }

        public string SendTextMessage(string message, string phoneNumber)
        {
            return _messageDevice.SendTextMessage(message, phoneNumber);
        }
    }

    public class AdditionalFeatures : IDevice
    {
        private IAdditionalFeatures _featuresDevice;
        
        public AdditionalFeatures(IAdditionalFeatures featuresDevice)
        {
            _featuresDevice = featuresDevice;
        }
        
        public string PlayMusic(string songTitle)
        {
            return _featuresDevice.PlayMusic(songTitle);
        }

        public string AccessInternet(string url)
        {
            return _featuresDevice.AccessInternet(url);
        }
    }
    public class Device
    {
        private IDevice _device;

        public Device(IDevice device)
        {
            _device = device;
        }

        public string PerformAction(string performAction)
        {
            return performAction;
        }
    }
}
