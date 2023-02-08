using MobileMonitoring.Shared;

namespace MobileMonitoring.Server
{
    public class MonitoringContext
    {
        public List<Company>        Companies       { get; } = new();
        public List<User>           Users           { get; } = new();
        public List<EmailStatus>    EmailStatuses   { get; } = new();
        public List<Email>          Emails          { get; } = new();
        public List<AlertType>      AlertTypes      { get; } = new();
        public List<Cleanup>        Cleanups        { get; } = new();
        public List<ModuleDynamics> ModulesDynamics { get; } = new();
        public List<Tile>           Tiles           { get; } = new();
        public List<NumberSequence> NumberSequences { get; } = new();

        public void Initialize()
        {
            /*
             * Companies
             */
            Companies.Add(new Company() { Name = "FR01"});
            Companies.Add(new Company() { Name = "DAT"});
            Companies.Add(new Company() { Name = "USMF"});

            /*
             * Users
             */
            Users.Add(new User()
            {
                FullName = "Gwendoline Pimprenelle",
                DynamicsId = 6452154,
                Company = Companies[0]
            });
            Users.Add(new User()
            {
                FullName = "Pablo De La Rosa",
                DynamicsId = 2156485,
                Company = Companies[1]
            });
            Users.Add(new User()
            {
                FullName = "Bob the sponge",
                DynamicsId = 9876543,
                Company = Companies[1]
            });

            /*
             * EmailStatusese
             */
            EmailStatuses.Add(new EmailStatus() { Name = "Send"});
            EmailStatuses.Add(new EmailStatus() { Name = "Pending"});
            EmailStatuses.Add(new EmailStatus() { Name = "Unsend"});

            /*
             * Emails
             */
            Emails.Add(new Email()
            {
                CreationDate = DateTime.Now,
                UserSender = Users[0],
                UserReceiver = Users[1],
                EmailStatus = EmailStatuses[0],
                Subject = "Review task KJB000012"
            });
            Emails.Add(new Email()
            {
                CreationDate = new DateTime(2018, 12, 27, 8, 0, 0),
                UserSender = Users[1],
                UserReceiver = Users[0],
                EmailStatus = EmailStatuses[1],
                Subject = "FR:Review task KJB000012"
            });
            Emails.Add(new Email()
            {
                CreationDate = new DateTime(2019, 2, 17, 20, 15, 43),
                UserSender = Users[0],
                UserReceiver = Users[2],
                EmailStatus = EmailStatuses[2],
                Subject = "What's taht Task KJB000012 ??"
            });

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
                User = Users[0],
                CleanupDate = new DateTime(2022, 10, 5, 11, 24, 15),
                AlertCreationDate = new DateTime(2015, 8, 4, 0, 56, 0),
                AlertType = AlertTypes[0]
            });
            Cleanups.Add(new Cleanup()
            {
                User = Users[1],
                CleanupDate = new DateTime(2021, 4, 14, 1, 12, 0),
                AlertCreationDate = new DateTime(2014, 3, 28, 9, 42, 0),
                AlertType = AlertTypes[1]
            });
            Cleanups.Add(new Cleanup()
            {
                User = Users[2],
                CleanupDate = new DateTime(2023, 12, 31, 11, 55, 15),
                AlertCreationDate = new DateTime(2017, 6, 7, 12, 56, 0),
                AlertType = AlertTypes[2]
            });

            /*
             * ModulesDynamics
             */
            ModulesDynamics.Add(new ModuleDynamics() { Name = "System administration" });
            ModulesDynamics.Add(new ModuleDynamics() { Name = "Unsent emails" });
            ModulesDynamics.Add(new ModuleDynamics() { Name = "Due Number sequences" });

            /*
             * Tiles
             */
            Tiles.Add(new Tile()
            {
                Name = "Notifications cleanup",
                Number = 15,
                Alert = false,
                ModuleDynamics = ModulesDynamics[0]
            });            
            Tiles.Add(new Tile()
            {
                Name = "Cleanup batch history custom",
                Number = 1.5,
                Alert = true,
                ModuleDynamics = ModulesDynamics[0]
            });            
            Tiles.Add(new Tile()
            {
                Name = "Database Cleanup",
                Number = 735.6,
                Alert = false,
                ModuleDynamics = ModulesDynamics[0]
            });            
            Tiles.Add(new Tile()
            {
                Name = "Unsent emails",
                Alert = false,
                ModuleDynamics = ModulesDynamics[1]
            });            
            Tiles.Add(new Tile()
            {
                Name = "Due Number sequences",
                Alert = false,
                ModuleDynamics = ModulesDynamics[2]
            });

            /*
             * NumberSequences
             */
            NumberSequences.Add(new NumberSequence()
            { 
                CompanyId = Companies[0].IdCompany,
                NbSequence = "DAT-0000001",
                InUse= false,
                Remaining = 100
            });
            NumberSequences.Add(new NumberSequence()
            { 
                CompanyId = Companies[0].IdCompany,
                NbSequence = "DAT-4585654",
                InUse= true,
                Remaining = 51
            });
            NumberSequences.Add(new NumberSequence()
            { 
                CompanyId = Companies[1].IdCompany,
                NbSequence = "FRSI-74023465",
                InUse= true,
                Remaining = 75
            });
            NumberSequences.Add(new NumberSequence()
            { 
                CompanyId = Companies[2].IdCompany,
                NbSequence = "UMF-8249758",
                InUse= true,
                Remaining = 8
            });

        }
    }
}
