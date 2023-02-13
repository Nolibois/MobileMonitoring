namespace MobileMonitoring.Shared
{
    public record CleanupDto(int IdCleanup, string User, string Company, DateTime CleanupDate, DateTime AlertCreationDate, string AlertType)
    {
        #region for deserialyzation only
        public CleanupDto() : this(default, "", "", default, default, "") { }
        #endregion

        public CleanupDto(Cleanup cleanup) : this(cleanup.IdCleanup, cleanup.User.FullName, cleanup.User.Company.Name, cleanup.CleanupDate, cleanup.AlertCreationDate, cleanup.AlertType.Name) { }
    }
}
