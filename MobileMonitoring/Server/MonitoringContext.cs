using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;
using Newtonsoft.Json;

namespace MobileMonitoring.Server
{
    public class MonitoringContext :DbContext
    {
        /*public MonitoringContext(DbContextOptions<MonitoringContext> options) : base(options)
        {

        }*/

        public MonitoringContext([JsonProperty("options")] DbContextOptions<MonitoringContext> options) : base(options) { }


        public DbSet<Company>        Companies       { get; set; }
        public DbSet<User>           Users           { get; set; }
        public DbSet<EmailStatus>    EmailStatuses   { get; set; }
        public DbSet<Email>          Emails          { get; set; }
        public DbSet<AlertType>      AlertTypes      { get; set; }
        public DbSet<Cleanup>        Cleanups        { get; set; }
        public DbSet<ModuleDynamics> ModulesDynamics { get; set; }
        public DbSet<Tile>           Tiles           { get; set; }
        public DbSet<NumberSequence> NumberSequences { get; set; }
        public DbSet<Threshold>      Threshold       { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
             * Companies
             */
            modelBuilder.Entity<Company>().ToTable("Companies").HasData(
                new Company() { IdCompany = 1, Name = "FR01" },
                new Company() { IdCompany = 2, Name = "DAT" },
                new Company() { IdCompany = 3, Name = "USMF" }
            );


            /*
             * Users
             */
            modelBuilder.Entity<User>().ToTable("Users").HasData(
                new User()
                {
                    IdUser = 1,
                    FullName = "Gwendoline Pimprenelle",
                    DynamicsId = 6452154,
                    CompanyId = 1
                },
                new User()
                {
                    IdUser = 2,
                    FullName = "Pablo De La Rosa",
                    DynamicsId = 2156485,
                    CompanyId = 1
                },
                new User()
                {
                    IdUser = 3,
                    FullName = "Bob the sponge",
                    DynamicsId = 9876543,
                    CompanyId = 3
                }
            );

            modelBuilder.Entity<User>()
                .HasOne(user => user.Company)
                .WithMany()
                .HasForeignKey(user => user.CompanyId);


            /*
             * EmailStatuses
             */
            modelBuilder.Entity<EmailStatus>().ToTable("EmailStatuses").HasData(
                new EmailStatus() { IdEmailStatus = 1, Name = "Send" },
                new EmailStatus() { IdEmailStatus = 2, Name = "Pending" },
                new EmailStatus() { IdEmailStatus = 3, Name = "Unsend" }
            );
           

            /*
             * Emails
             */
            modelBuilder.Entity<Email>().ToTable("Emails").HasData(
                new Email()
                {
                    IdEmail = 1,
                    CreationDate = DateTime.Now,
                    Subject = "Review task KJB000012",
                    UserSenderId = 1,
                    UserReceiverId = 2,
                    EmailStatusId = 1,
                },
                new Email()
                {
                    IdEmail = 2,
                    CreationDate = new DateTime(2018, 12, 27, 8, 0, 0),
                    Subject = "FR:Review task KJB000012",
                    UserSenderId = 2,
                    UserReceiverId = 1,
                    EmailStatusId = 2,
                },
                new Email()
                {
                    IdEmail = 3,
                    CreationDate = new DateTime(2019, 2, 17, 20, 15, 43),
                    Subject = "What's taht Task KJB000012 ??",
                    UserSenderId = 1,
                    UserReceiverId = 3,
                    EmailStatusId = 3,
                }
            );

            modelBuilder.Entity<Email>()
                .HasOne(email => email.UserSender)
                .WithMany()
                .HasForeignKey(email => email.UserSenderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Email>()
                .HasOne(email => email.UserReceiver)
                .WithMany()
                .HasForeignKey(email => email.UserReceiverId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Email>()
                .HasOne(email => email.EmailStatus)
                .WithMany()
                .HasForeignKey(email => email.EmailStatusId)
                .OnDelete(DeleteBehavior.NoAction);


            /*
             * AlertTypes
             */
            modelBuilder.Entity<AlertType>().ToTable("AlertTypes").HasData(
                new AlertType() { IdAlertType = 1, Name = "Notifications" },
                new AlertType() { IdAlertType = 2, Name = "Batch history custom" },
                new AlertType() { IdAlertType = 3, Name = "Batch database" }
            );


            /*
             * Cleanups
             */
            modelBuilder.Entity<Cleanup>().ToTable("Cleanups").HasData(
                new Cleanup()
                {
                    IdCleanup = 00001,
                    CleanupDate = new DateTime(2022, 10, 5, 11, 24, 15),
                    AlertCreationDate = new DateTime(2015, 8, 4, 0, 56, 0),
                    UserId = 1,
                    TileId = 1,
                    AlertTypeId = 1
                },
                new Cleanup()
                {
                    IdCleanup = 00002,
                    CleanupDate = new DateTime(2021, 4, 14, 1, 12, 0),
                    AlertCreationDate = new DateTime(2014, 3, 28, 9, 42, 0),
                    UserId = 2,
                    TileId = 2,
                    AlertTypeId = 2
                },
                new Cleanup()
                {
                    IdCleanup = 00003,
                    CleanupDate = new DateTime(2023, 12, 31, 11, 55, 15),
                    AlertCreationDate = new DateTime(2017, 6, 7, 12, 56, 0),
                    UserId = 3,
                    TileId = 3,
                    AlertTypeId = 3
                }
            );
            modelBuilder.Entity<Cleanup>()
                .HasOne(cleanup => cleanup.User)
                .WithMany()
                .HasForeignKey(cleanup => cleanup.UserId);

            modelBuilder.Entity<Cleanup>()
                .HasOne(cleanup => cleanup.AlertType)
                .WithMany()
                .HasForeignKey(cleanup => cleanup.AlertTypeId);

            modelBuilder.Entity<Cleanup>()
                .HasOne(cleanup => cleanup.Tile)
                .WithMany()
                .HasForeignKey(cleanup => cleanup.TileId);


            /*
             * ModulesDynamics
             */
            modelBuilder.Entity<ModuleDynamics>().ToTable("ModulesDynamics").HasData(
                new ModuleDynamics() { IdModule = 1, Name = "System administration" },
                new ModuleDynamics() { IdModule = 2, Name = "Unsent emails" },
                new ModuleDynamics() { IdModule = 3, Name = "Due Number sequences" }, 
                new ModuleDynamics() { IdModule = 4, Name = "General Ledger" }
            );


            /*
             * Tiles
             */
            modelBuilder.Entity<Tile>().ToTable("Tiles").HasData(
                new Tile()
                {
                    IdTile = 1,
                    Name = "Notifications cleanup",
                    Number = 15,
                    Alert = false,
                    ModuleDynamicsId = 1,
                    ThresholdId = 1
                },
                new Tile()
                {
                    IdTile = 2,
                    Name = "Cleanup batch history custom",
                    Number = 25,
                    Alert = false,
                    ModuleDynamicsId = 1,
                    ThresholdId = 2
                },
                new Tile()
                {
                    IdTile = 3,
                    Name = "Database Cleanup",
                    Number = 735.6,
                    Alert = false,
                    ModuleDynamicsId = 1,
                    ThresholdId = 3
                },
                new Tile()
                {
                    IdTile = 4,
                    Name = "Unsent emails",
                    Number = 452,
                    Alert = false,
                    ModuleDynamicsId = 2,
                    ThresholdId = 4
                },
                new Tile()
                {
                    IdTile = 5,
                    Name = "Due Number sequences",
                    Alert = false,
                    ModuleDynamicsId = 3,
                    ThresholdId = 5
                }
            );

            modelBuilder.Entity<Tile>()
                .HasOne(tile => tile.ModuleDynamics)
                .WithMany()
                .HasForeignKey(tile => tile.ModuleDynamicsId);

            modelBuilder.Entity<Tile>()
                .HasOne(tile => tile.Threshold)
                .WithMany()
                .HasForeignKey(tile => tile.ThresholdId);

            /*
             * Threshold
             */
            modelBuilder.Entity<Threshold>().ToTable("Threshold").HasData(
                new Threshold() { IdThreshold = 1, ThresholdWarnings = 0 },
                new Threshold() { IdThreshold = 2, ThresholdWarnings = 0 },
                new Threshold() { IdThreshold = 3, ThresholdWarnings = 0 },
                new Threshold() { IdThreshold = 4, ThresholdWarnings = 0 },
                new Threshold() { IdThreshold = 5, ThresholdWarnings = 0 }
            );

            /*
             * NumberSequences
             */
            modelBuilder.Entity<NumberSequence>().ToTable("NumberSequences").HasData(
                new NumberSequence()
                {
                    IdNumberSequence = 1,
                    NbSequence = "DAT-0000001",
                    InUse = false,
                    Remaining = 100,
                    CompanyId = 2
                },
                new NumberSequence()
                {
                    IdNumberSequence = 2,
                    NbSequence = "DAT-4585654",
                    InUse = true,
                    Remaining = 51,
                    CompanyId = 2
                },
                new NumberSequence()
                {
                    IdNumberSequence = 3,
                    NbSequence = "FRSI-74023465",
                    InUse = true,
                    Remaining = 75,
                    CompanyId = 1
                },
                new NumberSequence()
                {
                    IdNumberSequence = 4,
                    NbSequence = "USMF-8249758",
                    InUse = true,
                    Remaining = 8,
                    CompanyId = 3
                }
            );
            
            modelBuilder.Entity<NumberSequence>()
                .HasOne(numberSequence => numberSequence.Company)
                .WithMany()
                .HasForeignKey(numberSequence => numberSequence.CompanyId);
        }
    }
}
