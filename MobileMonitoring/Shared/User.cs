namespace MobileMonitoring.Shared
{
    public class User
    {
        public int IdUser { get; set; }
        public required string FullName { get; set; }
        public required int IdDynamics { get; set; }
        public required int IdCompany { get; set; }
    }
}
