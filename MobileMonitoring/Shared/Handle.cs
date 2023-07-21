using System.ComponentModel.DataAnnotations.Schema;

namespace MobileMonitoring.Shared
{
    public class Handle
    {
        [ForeignKey("User")]
        public int IdUser { get; set; }
        [ForeignKey("Cleanup")]
        public int IdCleanup { get; set; }

        #region Populated by EF Core
        #pragma warning disable CS8618 // Non-nullable field is uninitialized
        public virtual User User { get; set; }
        public virtual Cleanup Cleanup { get; set; }
        #pragma warning restore CS8618
        #endregion

    }
}
