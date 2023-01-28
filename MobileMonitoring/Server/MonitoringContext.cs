using MobileMonitoring.Shared;
using System.Xml.Linq;

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
            /*
             * Emails
             */
            Emails.Add(new Email() 
            { 
                CreationDate= DateTime.Now,
                IdUser = Users[0].IdUser,
                Recipient = Users[1].FullName,
                IdEmailStatus = EmailStatuses[0].IdEmailStatus,
                Subject = "Review task KJB000012"
            });
            Emails.Add(new Email()
            { 
                CreationDate= new DateTime(2018, 12, 27, 8, 0, 0),
                IdUser = Users[1].IdUser,
                Recipient = Users[0].FullName,
                IdEmailStatus = EmailStatuses[1].IdEmailStatus,
                Subject = "FR:Review task KJB000012"
            });
            Emails.Add(new Email()
            { 
                CreationDate= new DateTime(2019, 2, 17, 20, 15, 43) ,
                IdUser = Users[0].IdUser,
                Recipient = Users[2].FullName,
                IdEmailStatus = EmailStatuses[2].IdEmailStatus,
                Subject = "What's taht Task KJB000012 ??"
            });

            /*
             * Users
             */
            Users.Add(new User()
            { 
                FullName = "Gwendoline Pimprenelle",
                IdDynamics = 6452154,
                IdCompany = Companies[0].IdCompany
            });
            Users.Add(new User()
            { 
                FullName = "Pablo De La Rosa",
                IdDynamics = 2156485,
                IdCompany = Companies[1].IdCompany
            });
            Users.Add(new User()
            { 
                FullName = "Pablo De La Rosa",
                IdDynamics = 2156485,
                IdCompany = Companies[1].IdCompany
            });

            /*
             * Companies
             */
            Companies.Add(new Company() { Name = "FR01"});
            Companies.Add(new Company() { Name = "DAT"});
            Companies.Add(new Company() { Name = "USMF"});

            /*
             * EmailStatus
             */
            EmailStatuses.Add(new EmailStatus() { Name = "Send"});
            EmailStatuses.Add(new EmailStatus() { Name = "Pending"});
            EmailStatuses.Add(new EmailStatus() { Name = "Unsend"});

            /*
             * AlertTypes
             */
            AlertTypes.Add(new AlertType() { Name = "Notification" });
            AlertTypes.Add(new AlertType() { Name = "Batch history custom" });
            AlertTypes.Add(new AlertType() { Name = "Batch database" });

            /*
             * Cleanups
             */
            Cleanups.Add(new Cleanup()
            {
                IdUser = Users[1].IdUser,
                CleanupDate = new DateTime(2022, 10, 5, 11, 24, 15),
                AlertCreationDate = new DateTime(2015, 8, 4, 0, 56, 0),
                IdAlertType = AlertTypes[0].IdAlertType
            });
            Cleanups.Add(new Cleanup()
            {
                IdUser = Users[1].IdUser,
                CleanupDate = new DateTime(2021, 4, 14, 1, 12, 0),
                AlertCreationDate = new DateTime(2014, 3, 28, 9, 42, 0),
                IdAlertType = AlertTypes[0].IdAlertType
            });
            Cleanups.Add(new Cleanup()
            {
                IdUser = Users[2].IdUser,
                CleanupDate = new DateTime(2023, 12, 31, 11, 55, 15),
                AlertCreationDate = new DateTime(2017, 6, 7, 12, 56, 0),
                IdAlertType = AlertTypes[0].IdAlertType
            });
    }
}
