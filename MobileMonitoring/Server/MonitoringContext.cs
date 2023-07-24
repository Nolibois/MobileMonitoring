using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;
using Newtonsoft.Json;
using System.ComponentModel.Design;

namespace MobileMonitoring.Server
{
    public class MonitoringContext :DbContext
    {

        public MonitoringContext([JsonProperty("options")] DbContextOptions<MonitoringContext> options) : base(options) { }


        public DbSet<Company>           Companies       { get; set; }
        public DbSet<User>              Users           { get; set; }
        public DbSet<Handle>            Handles         { get; set; }
        public DbSet<EmailStatus>       EmailStatuses   { get; set; }
        public DbSet<Email>             Emails          { get; set; }
        public DbSet<AlertType>         AlertTypes      { get; set; }
        public DbSet<Cleanup>           Cleanups        { get; set; }
        public DbSet<ModuleDynamics>    ModulesDynamics { get; set; }
        public DbSet<Tile>              Tiles           { get; set; }
        public DbSet<NumberSequence>    NumberSequences { get; set; }
        public DbSet<Threshold>         Threshold       { get; set; }

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
                    IdUser      = 1,
                    FullName    = "Gwendoline Pimprenelle",
                    DynamicsId  = 6452154,
                    CompanyId   = 1
                },
                new User()
                {
                    IdUser      = 2,
                    FullName    = "Pablo De La Rosa",
                    DynamicsId  = 2156485,
                    CompanyId   = 1
                },
                new User()
                {
                    IdUser      = 3,
                    FullName    = "Bob the sponge",
                    DynamicsId  = 9876543,
                    CompanyId   = 3
                },
                new User()
                {
                    IdUser      = 4,
                    FullName    = "Julie Lespine",
                    DynamicsId  = 2156821,
                    CompanyId   = 1
                },
                new User()
                {
                    IdUser      = 5,
                    FullName    = "Yasmine Sbn Seddick",
                    DynamicsId  = 7458962,
                    CompanyId   = 2
                },
                new User()
                {
                    IdUser      = 6,
                    FullName    = "Bob the sponge",
                    DynamicsId  = 9877578,
                    CompanyId   = 3
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
                    IdEmail         = 1,
                    CreationDate    = DateTime.Now,
                    Subject         = "Review task KJB000012",
                    UserSenderId    = 1,
                    UserReceiverId  = 2,
                    EmailStatusId   = 3,
                },
                new Email()
                {
                    IdEmail         = 2,
                    CreationDate    = new DateTime(2018, 12, 27, 8, 0, 0),
                    Subject         = "FR:Review task KJB000012",
                    UserSenderId    = 2,
                    UserReceiverId  = 1,
                    EmailStatusId   = 2,
                },
                new Email()
                {
                    IdEmail         = 3,
                    CreationDate    = new DateTime(2019, 2, 17, 20, 15, 43),
                    Subject         = "What's taht Task KJB000012 ??",
                    UserSenderId    = 1,
                    UserReceiverId  = 3,
                    EmailStatusId   = 3,
                },
                new Email()
                {
                    IdEmail         = 4,
                    CreationDate    = new DateTime(2022, 4, 21, 8, 0, 0),
                    Subject         = "Account receiver",
                    UserSenderId    = 6,
                    UserReceiverId  = 2,
                    EmailStatusId   = 3,
},
                new Email()
                {
                    IdEmail         = 5,
                    CreationDate    = new DateTime(2018, 12, 27, 8, 0, 0),
                    Subject         = "Account payable ",
                    UserSenderId    = 2,
                    UserReceiverId  = 4,
                    EmailStatusId   = 3,
                },
                new Email()
                {
                    IdEmail         = 6,
                    CreationDate    = new DateTime(2019, 2, 17, 20, 15, 43),
                    Subject         = "Ledger General to review",
                    UserSenderId    = 5,
                    UserReceiverId  = 1,
                    EmailStatusId   = 2,
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
                    IdCleanup           = 00001,
                    CleanupDate         = new DateTime(2024, 10, 5, 11, 24, 15),
                    AlertCreationDate   = new DateTime(2015, 8, 4, 0, 56, 0),
                    UserId              = 1,
                    TileId              = 1,
                    AlertTypeId         = 1
                }, new Cleanup()
                {
                    IdCleanup           = 00002,
                    CleanupDate         = new DateTime(2023, 11, 8, 4, 10, 15),
                    AlertCreationDate   = new DateTime(2018, 9, 3, 0, 56, 0),
                    UserId              = 6,
                    TileId              = 1,
                    AlertTypeId         = 1
                }, new Cleanup()
                {
                    IdCleanup           = 00003,
                    CleanupDate         = new DateTime(2024, 7, 2, 10, 24, 15),
                    AlertCreationDate   = new DateTime(2019, 8, 28, 10, 56, 0),
                    UserId              = 4,
                    TileId              = 1,
                    AlertTypeId         = 1
                }, new Cleanup()
                {
                    IdCleanup           = 00004,
                    CleanupDate         = new DateTime(2024, 4, 18, 11, 24, 15),
                    AlertCreationDate   = new DateTime(2017, 10, 4, 0, 56, 0),
                    UserId              = 2,
                    TileId              = 1,
                    AlertTypeId         = 1
                },
                new Cleanup()
                {
                    IdCleanup           = 00005,
                    CleanupDate         = new DateTime(2025, 5, 14, 1, 12, 0),
                    AlertCreationDate   = new DateTime(2014, 3, 28, 9, 42, 0),
                    UserId              = 2,
                    TileId              = 1,
                    AlertTypeId         = 1
                },
                new Cleanup()
                {
                    IdCleanup           = 00006,
                    CleanupDate         = new DateTime(2026, 2, 28, 1, 12, 0),
                    AlertCreationDate   = new DateTime(2019, 1, 2, 9, 42, 0),
                    UserId              = 2,
                    TileId              = 2,
                    AlertTypeId         = 2
                },
                new Cleanup()
                {
                    IdCleanup           = 00007,
                    CleanupDate         = new DateTime(2025, 11, 14, 1, 12, 0),
                    AlertCreationDate   = new DateTime(2019, 10, 18, 9, 42, 0),
                    UserId              = 4,
                    TileId              = 2,
                    AlertTypeId         = 2
                }, 
                new Cleanup()
                {
                    IdCleanup           = 00008,
                    CleanupDate         = new DateTime(2024, 11, 21, 1, 12, 0),
                    AlertCreationDate   = new DateTime(2017, 8, 31, 9, 42, 0),
                    UserId              = 3,
                    TileId              = 2,
                    AlertTypeId         = 2
                }, 
                new Cleanup()
                {
                    IdCleanup           = 00009,
                    CleanupDate         = new DateTime(2023, 11, 12, 1, 12, 0),
                    AlertCreationDate   = new DateTime(2014, 7, 19, 9, 42, 0),
                    UserId              = 2,
                    TileId              = 2,
                    AlertTypeId         = 2
                },
                new Cleanup()
                {
                    IdCleanup           = 00010,
                    CleanupDate         = new DateTime(2023, 12, 14, 11, 55, 15),
                    AlertCreationDate   = new DateTime(2017, 6, 7, 12, 56, 0),
                    UserId              = 3,
                    TileId              = 2,
                    AlertTypeId         = 2
                },
                new Cleanup()
                {
                    IdCleanup           = 00011,
                    CleanupDate         = new DateTime(2024, 10, 8, 11, 55, 15),
                    AlertCreationDate   = new DateTime(2017, 11, 17, 12, 56, 0),
                    UserId              = 4,
                    TileId              = 3,
                    AlertTypeId         = 3
                },
                new Cleanup()
                {
                    IdCleanup           = 00012,
                    CleanupDate         = new DateTime(2028, 9, 12, 11, 55, 15),
                    AlertCreationDate   = new DateTime(2017, 11, 7, 12, 56, 0),
                    UserId              = 2,
                    TileId              = 3,
                    AlertTypeId         = 3
                },
                new Cleanup()
                {
                    IdCleanup           = 00013,
                    CleanupDate         = new DateTime(2024, 4, 2, 11, 55, 15),
                    AlertCreationDate   = new DateTime(2016, 9, 27, 12, 56, 0),
                    UserId              = 1,
                    TileId              = 3,
                    AlertTypeId         = 3
                },
                new Cleanup()
                {
                    IdCleanup           = 00014,
                    CleanupDate         = new DateTime(2026, 3, 22, 11, 55, 15),
                    AlertCreationDate   = new DateTime(2016, 12, 7, 12, 56, 0),
                    UserId              = 3,
                    TileId              = 3,
                    AlertTypeId         = 3
                }
            );

            modelBuilder.Entity<Cleanup>()
                .HasOne(cleanup => cleanup.AlertType)
                .WithMany()
                .HasForeignKey(cleanup => cleanup.AlertTypeId);

            modelBuilder.Entity<Cleanup>()
                .HasOne(cleanup => cleanup.Tile)
                .WithMany()
                .HasForeignKey(cleanup => cleanup.TileId);

            /*
             * Handles
             */
            modelBuilder.Entity<Handle>().ToTable("Handles").HasNoKey();
            
            modelBuilder.Entity<Handle>()
                .HasOne(handle => handle.User)
                .WithMany()
                .HasForeignKey(handle => handle.IdUser)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Handle>()
                .HasOne(Handle=> Handle.Cleanup)
                .WithMany()
                .HasForeignKey(Handle => Handle.IdCleanup)
                .OnDelete(DeleteBehavior.NoAction);


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
                    IdTile              = 1,
                    Name                = "Notifications cleanup",
                    Number              = 15,
                    Alert               = false,
                    ModuleDynamicsId    = 1,
                    ThresholdId         = 1
                },
                new Tile()
                {
                    IdTile              = 2,
                    Name                = "Cleanup batch history custom",
                    Number              = 25,
                    Alert               = false,
                    ModuleDynamicsId    = 1,
                    ThresholdId         = 2
                },
                new Tile()
                {
                    IdTile              = 3,
                    Name                = "Database cleanup",
                    Number              = 89,
                    Alert               = false,
                    ModuleDynamicsId    = 1,
                    ThresholdId         = 3
                },
                new Tile()
                {
                    IdTile              = 4,
                    Name                = "Unsent emails",
                    Number              = 75,
                    Alert               = false,
                    ModuleDynamicsId    = 2,
                    ThresholdId         = 4
                },
                new Tile()
                {
                    IdTile              = 5,
                    Name                = "Due number sequences",
                    Alert               = false,
                    ModuleDynamicsId    = 3,
                    ThresholdId         = 5
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
                new Threshold() { IdThreshold = 1, ThresholdWarnings = 10 },
                new Threshold() { IdThreshold = 2, ThresholdWarnings = 10 },
                new Threshold() { IdThreshold = 3, ThresholdWarnings = 10 },
                new Threshold() { IdThreshold = 4, ThresholdWarnings = 10 },
                new Threshold() { IdThreshold = 5, ThresholdWarnings = 1 }
            );

            /*
             * NumberSequences
             */
            modelBuilder.Entity<NumberSequence>().ToTable("NumberSequences").HasData(
                new NumberSequence()
                {
                    IdNumberSequence    = 1,
                    NbSequence          = "DAT-PO-0000001",
                    InUse               = false,
                    Remaining           = 100,
                    CompanyId           = 2
                },
                new NumberSequence()
                {
                    IdNumberSequence    = 2,
                    NbSequence          = "DAT-SO-4585654",
                    InUse               = true,
                    Remaining           = 51,
                    CompanyId           = 2
                },
                new NumberSequence()
                {
                    IdNumberSequence    = 3,
                    NbSequence          = "FRSI-PO-7402346",
                    InUse               = true,
                    Remaining           = 75,
                    CompanyId           = 1
                },
                new NumberSequence()
                {
                    IdNumberSequence    = 4,
                    NbSequence          = "USMF-PO-8249758",
                    InUse               = true,
                    Remaining           = 8,
                    CompanyId           = 3
                },
                new NumberSequence()
                {
                    IdNumberSequence    = 5,
                    NbSequence = "DAT-PS-0451257",
                    InUse = true,
                    Remaining = 45,
                    CompanyId = 2
                },
                new NumberSequence()
                {
                    IdNumberSequence = 6,
                    NbSequence = "FRSI-SO-0085654",
                    InUse = true,
                    Remaining = 1,
                    CompanyId = 2
                },
                new NumberSequence()
                {
                    IdNumberSequence = 7,
                    NbSequence = "FRSI-7402365",
                    InUse = true,
                    Remaining = 75,
                    CompanyId = 1
                },
                new NumberSequence()
                {
                    IdNumberSequence = 8,
                    NbSequence = "USMF-8249758",
                    InUse = true,
                    Remaining = 82,
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
