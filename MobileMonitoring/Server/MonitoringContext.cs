using MobileMonitoring.Shared;

namespace MobileMonitoring.Server
{
    public class MonitoringContext
    {
        public List<Email>          Emails          {get; } = new();
        public List<User>           Users           {get; } = new();
        public List<Company>        Companies       {get; } = new();
        public List<EmailStatus>    EmailStatuses   {get; } = new();
        public List<AlertType>      AlertTypes      {get; } = new();
        public List<Cleanup>        Cleanups        {get; } = new();
        public List<Tile>           Tiles           {get; } = new();
        public List<Module>         Modules         {get; } = new();

        public void Initialize()
        {
            Emails.Add(new Email() { CreationDate= DateTime.Now });
            Emails.Add(new Email() { CreationDate= new DateTime(2018, 12, 27, 8, 0, 0) });
            Emails.Add(new Email() { CreationDate= new DateTime(2019, 2, 17, 20, 15, 43) });
        }
    }
}
