namespace CommunicationDevice.App
{
    public interface ITextMessage
    {
        string SendTextMessage(string message, string phoneNumber);
    }
}
