namespace CommunicationDevice.App
{
    public class Smartphone : ICall, ITextMessage, IAdditionalFeatures
    {
        public string AccessInternet(string url)
        {
            return ($"Connecting to \"{url}\" ...");
        }

        public string MakeCall(string phoneNumber)
        {
            return ($"Calling {phoneNumber} ...");
        }

        public string PlayMusic(string songTitle)
        {
            return ($"Playing {songTitle} ...");
        }

        public string SendTextMessage(string message, string phoneNumber)
        {
            return ($"Sending \"{message}\" to {phoneNumber} ...");
        }
    }
}
