namespace SimpleEmailApp.Services.EmailServices
{
    public interface IEmailServices
    {
        void SendEmail(EmailDto request);
    }
}
