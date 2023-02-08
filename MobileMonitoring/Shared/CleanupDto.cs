namespace MobileMonitoring.Shared
{
    public record CleanupDto(int IdCleanup, string User, DateTime CleanupDate, DateTime AlertCreationDate, string AlertType)
    {
        public CleanupDto(Cleanup cleanup) : this(cleanup.IdCleanup, cleanup.User.FullName, cleanup.CleanupDate, cleanup.AlertCreationDate, cleanup.AlertType.Name) { }
    }
}
