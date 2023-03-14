namespace MobileMonitoring.Shared
{
    public record EmailDto(int IdEmail, string UserSender, string UserReceiver, string Subject, DateTime CreationDate)
    {
        #region for deserialyzation only
        public EmailDto() : this(default, "", "", "", default) { }
        #endregion

        public EmailDto(Email email) : this(email.IdEmail, email.UserSender.FullName, email.UserReceiver.FullName, email.Subject, email.CreationDate) { }
    }
}
