namespace MobileMonitoring.Shared
{
    public class Email
    {
        public int IdEmail { get; set; }
        public required int IdUser { get; set; }
        public required string Recipient { get; set; }
        public required int IdEmailStatus { get; set; }
        public required string Subject { get; set; }
        public required DateTime CreationDate { get; set; }
    }
}
