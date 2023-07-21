namespace MobileMonitoring.Shared
{
    public record HandleDto(int UserId, int CleanupId)
    {
        #region for deserialyzation only
        public HandleDto() : this(default, default) { }
        #endregion

        public HandleDto(Handle handle) : this(handle.User.IdUser, handle.Cleanup.IdCleanup) { }
    }
}
