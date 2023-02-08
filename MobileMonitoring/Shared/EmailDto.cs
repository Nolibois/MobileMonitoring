namespace MobileMonitoring.Shared
{
    public record EmailDto(int IdEmail, string UserSender, string UserReceiver, string Subject, DateTime CreationDate)
    {
        public EmailDto(Email email) : this(email.IdEmail, email.UserSender.FullName, email.UserReceiver.FullName, email.Subject, email.CreationDate) { }
    }
}
