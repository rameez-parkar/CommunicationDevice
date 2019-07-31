namespace CommunicationDevice.App
{
    public class Mobile : ICall, ITextMessage
    {
        public string MakeCall(string phoneNumber)
        {
            return ($"Calling {phoneNumber} ...");
        }

        public string SendTextMessage(string message, string phoneNumber)
        {
            return ($"Sending \"{message}\" to {phoneNumber} ...");
        }
    }
}
