namespace Before.Settings
{
    public interface ISiteSettings
    {
        int CacheTimeoutMinutes { get; }

        string Title { get; }

        string EmailSenderName { get; }

        string EmailSenderAddress { get; }
    }
}
