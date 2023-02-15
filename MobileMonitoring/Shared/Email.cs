using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Email
    {
        [Key, JsonIgnore]
        public int IdEmail { get; set; }

        public int UserSenderId { get; set; }
        public int UserReceiverId { get; set; }
        public int EmailStatusId { get; set; }

        [Required, StringLength(200)]
        public required string Subject { get; set; }

        public required DateTime CreationDate { get; set; }

        #region Populated by EF Core
        #pragma warning disable CS8618 // Non-nullable field is uninitialized
        public virtual User UserSender { get; set; }
        public virtual User UserReceiver { get; set; }
        public virtual EmailStatus EmailStatus { get; set; }
        #pragma warning restore CS8618
        #endregion
    }
}
