namespace CommunicationDevice.App
{
    public class Telephone : ICall
    {
        public string MakeCall(string phoneNumber)
        {
            return ($"Calling {phoneNumber} ...");
        }
    }
}
