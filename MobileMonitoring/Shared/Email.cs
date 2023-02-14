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
        public required User UserSender { get; set; }
        public required User UserReceiver { get; set; }
        public required EmailStatus EmailStatus { get; set; }
        #endregion
    }
}
