namespace EarlyRegistration.Settings
{
    public interface IEmailSettings
    {
        string EmailSenderName { get; }

        string EmailSenderAddress { get; }
    }
}
