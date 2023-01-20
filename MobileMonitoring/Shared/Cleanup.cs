namespace MobileMonitoring.Shared
{
    public class Cleanup
    {
        public int  IdCleanup { get; set; }
        public int IdUser { get; set; }
        public required DateTime CleanupDate { get; set; }
        public required DateTime AlertCreationDate { get; set; }
        public int IdAlertType { get; set; }
    }
}
