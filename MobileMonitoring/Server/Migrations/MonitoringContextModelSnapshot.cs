﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileMonitoring.Server;

#nullable disable

namespace MobileMonitoring.Server.Migrations
{
    [DbContext(typeof(MonitoringContext))]
    partial class MonitoringContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MobileMonitoring.Shared.AlertType", b =>
                {
                    b.Property<int>("IdAlertType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlertType"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdAlertType");

                    b.ToTable("AlertTypes", (string)null);

                    b.HasData(
                        new
                        {
                            IdAlertType = 1,
                            Name = "Notifications"
                        },
                        new
                        {
                            IdAlertType = 2,
                            Name = "Batch history custom"
                        },
                        new
                        {
                            IdAlertType = 3,
                            Name = "Batch database"
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Cleanup", b =>
                {
                    b.Property<int>("IdCleanup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCleanup"));

                    b.Property<DateTime>("AlertCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AlertTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CleanupDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("IdCleanup");

                    b.HasIndex("AlertTypeId");

                    b.HasIndex("TileId");

                    b.HasIndex("UserId");

                    b.ToTable("Cleanups", (string)null);

                    b.HasData(
                        new
                        {
                            IdCleanup = 1,
                            AlertCreationDate = new DateTime(2015, 8, 4, 0, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 1,
                            CleanupDate = new DateTime(2024, 10, 5, 11, 24, 15, 0, DateTimeKind.Unspecified),
                            TileId = 1,
                            UserId = 1
                        },
                        new
                        {
                            IdCleanup = 2,
                            AlertCreationDate = new DateTime(2018, 9, 3, 0, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 1,
                            CleanupDate = new DateTime(2023, 11, 8, 4, 10, 15, 0, DateTimeKind.Unspecified),
                            TileId = 1,
                            UserId = 6
                        },
                        new
                        {
                            IdCleanup = 3,
                            AlertCreationDate = new DateTime(2019, 8, 28, 10, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 1,
                            CleanupDate = new DateTime(2024, 7, 2, 10, 24, 15, 0, DateTimeKind.Unspecified),
                            TileId = 1,
                            UserId = 4
                        },
                        new
                        {
                            IdCleanup = 4,
                            AlertCreationDate = new DateTime(2017, 10, 4, 0, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 1,
                            CleanupDate = new DateTime(2024, 4, 18, 11, 24, 15, 0, DateTimeKind.Unspecified),
                            TileId = 1,
                            UserId = 2
                        },
                        new
                        {
                            IdCleanup = 5,
                            AlertCreationDate = new DateTime(2014, 3, 28, 9, 42, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 1,
                            CleanupDate = new DateTime(2025, 5, 14, 1, 12, 0, 0, DateTimeKind.Unspecified),
                            TileId = 1,
                            UserId = 2
                        },
                        new
                        {
                            IdCleanup = 6,
                            AlertCreationDate = new DateTime(2019, 1, 2, 9, 42, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 2,
                            CleanupDate = new DateTime(2026, 2, 28, 1, 12, 0, 0, DateTimeKind.Unspecified),
                            TileId = 2,
                            UserId = 2
                        },
                        new
                        {
                            IdCleanup = 7,
                            AlertCreationDate = new DateTime(2019, 10, 18, 9, 42, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 2,
                            CleanupDate = new DateTime(2025, 11, 14, 1, 12, 0, 0, DateTimeKind.Unspecified),
                            TileId = 2,
                            UserId = 4
                        },
                        new
                        {
                            IdCleanup = 8,
                            AlertCreationDate = new DateTime(2017, 8, 31, 9, 42, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 2,
                            CleanupDate = new DateTime(2024, 11, 21, 1, 12, 0, 0, DateTimeKind.Unspecified),
                            TileId = 2,
                            UserId = 3
                        },
                        new
                        {
                            IdCleanup = 9,
                            AlertCreationDate = new DateTime(2014, 7, 19, 9, 42, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 2,
                            CleanupDate = new DateTime(2023, 11, 12, 1, 12, 0, 0, DateTimeKind.Unspecified),
                            TileId = 2,
                            UserId = 2
                        },
                        new
                        {
                            IdCleanup = 10,
                            AlertCreationDate = new DateTime(2017, 6, 7, 12, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 2,
                            CleanupDate = new DateTime(2023, 12, 14, 11, 55, 15, 0, DateTimeKind.Unspecified),
                            TileId = 2,
                            UserId = 3
                        },
                        new
                        {
                            IdCleanup = 11,
                            AlertCreationDate = new DateTime(2017, 11, 17, 12, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 3,
                            CleanupDate = new DateTime(2024, 10, 8, 11, 55, 15, 0, DateTimeKind.Unspecified),
                            TileId = 3,
                            UserId = 4
                        },
                        new
                        {
                            IdCleanup = 12,
                            AlertCreationDate = new DateTime(2017, 11, 7, 12, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 3,
                            CleanupDate = new DateTime(2028, 9, 12, 11, 55, 15, 0, DateTimeKind.Unspecified),
                            TileId = 3,
                            UserId = 2
                        },
                        new
                        {
                            IdCleanup = 13,
                            AlertCreationDate = new DateTime(2016, 9, 27, 12, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 3,
                            CleanupDate = new DateTime(2024, 4, 2, 11, 55, 15, 0, DateTimeKind.Unspecified),
                            TileId = 3,
                            UserId = 1
                        },
                        new
                        {
                            IdCleanup = 14,
                            AlertCreationDate = new DateTime(2016, 12, 7, 12, 56, 0, 0, DateTimeKind.Unspecified),
                            AlertTypeId = 3,
                            CleanupDate = new DateTime(2026, 3, 22, 11, 55, 15, 0, DateTimeKind.Unspecified),
                            TileId = 3,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Company", b =>
                {
                    b.Property<int>("IdCompany")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompany"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdCompany");

                    b.ToTable("Companies", (string)null);

                    b.HasData(
                        new
                        {
                            IdCompany = 1,
                            Name = "FR01"
                        },
                        new
                        {
                            IdCompany = 2,
                            Name = "DAT"
                        },
                        new
                        {
                            IdCompany = 3,
                            Name = "USMF"
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Email", b =>
                {
                    b.Property<int>("IdEmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmail"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmailStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("UserReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("UserSenderId")
                        .HasColumnType("int");

                    b.HasKey("IdEmail");

                    b.HasIndex("EmailStatusId");

                    b.HasIndex("UserReceiverId");

                    b.HasIndex("UserSenderId");

                    b.ToTable("Emails", (string)null);

                    b.HasData(
                        new
                        {
                            IdEmail = 1,
                            CreationDate = new DateTime(2023, 7, 24, 18, 9, 29, 837, DateTimeKind.Local).AddTicks(1808),
                            EmailStatusId = 3,
                            Subject = "Review task KJB000012",
                            UserReceiverId = 2,
                            UserSenderId = 1
                        },
                        new
                        {
                            IdEmail = 2,
                            CreationDate = new DateTime(2018, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailStatusId = 2,
                            Subject = "FR:Review task KJB000012",
                            UserReceiverId = 1,
                            UserSenderId = 2
                        },
                        new
                        {
                            IdEmail = 3,
                            CreationDate = new DateTime(2019, 2, 17, 20, 15, 43, 0, DateTimeKind.Unspecified),
                            EmailStatusId = 3,
                            Subject = "What's taht Task KJB000012 ??",
                            UserReceiverId = 3,
                            UserSenderId = 1
                        },
                        new
                        {
                            IdEmail = 4,
                            CreationDate = new DateTime(2022, 4, 21, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailStatusId = 3,
                            Subject = "Account receiver",
                            UserReceiverId = 2,
                            UserSenderId = 6
                        },
                        new
                        {
                            IdEmail = 5,
                            CreationDate = new DateTime(2018, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailStatusId = 3,
                            Subject = "Account payable ",
                            UserReceiverId = 4,
                            UserSenderId = 2
                        },
                        new
                        {
                            IdEmail = 6,
                            CreationDate = new DateTime(2019, 2, 17, 20, 15, 43, 0, DateTimeKind.Unspecified),
                            EmailStatusId = 2,
                            Subject = "Ledger General to review",
                            UserReceiverId = 1,
                            UserSenderId = 5
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.EmailStatus", b =>
                {
                    b.Property<int>("IdEmailStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmailStatus"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdEmailStatus");

                    b.ToTable("EmailStatuses", (string)null);

                    b.HasData(
                        new
                        {
                            IdEmailStatus = 1,
                            Name = "Send"
                        },
                        new
                        {
                            IdEmailStatus = 2,
                            Name = "Pending"
                        },
                        new
                        {
                            IdEmailStatus = 3,
                            Name = "Unsend"
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Handle", b =>
                {
                    b.Property<int>("IdCleanup")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasIndex("IdCleanup");

                    b.HasIndex("IdUser");

                    b.ToTable("Handles", (string)null);
                });

            modelBuilder.Entity("MobileMonitoring.Shared.ModuleDynamics", b =>
                {
                    b.Property<int>("IdModule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdModule"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdModule");

                    b.ToTable("ModulesDynamics", (string)null);

                    b.HasData(
                        new
                        {
                            IdModule = 1,
                            Name = "System administration"
                        },
                        new
                        {
                            IdModule = 2,
                            Name = "Unsent emails"
                        },
                        new
                        {
                            IdModule = 3,
                            Name = "Due Number sequences"
                        },
                        new
                        {
                            IdModule = 4,
                            Name = "General Ledger"
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.NumberSequence", b =>
                {
                    b.Property<int>("IdNumberSequence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNumberSequence"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<bool>("InUse")
                        .HasColumnType("bit");

                    b.Property<string>("NbSequence")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Remaining")
                        .HasColumnType("int");

                    b.HasKey("IdNumberSequence");

                    b.HasIndex("CompanyId");

                    b.ToTable("NumberSequences", (string)null);

                    b.HasData(
                        new
                        {
                            IdNumberSequence = 1,
                            CompanyId = 2,
                            InUse = false,
                            NbSequence = "DAT-PO-0000001",
                            Remaining = 100
                        },
                        new
                        {
                            IdNumberSequence = 2,
                            CompanyId = 2,
                            InUse = true,
                            NbSequence = "DAT-SO-4585654",
                            Remaining = 51
                        },
                        new
                        {
                            IdNumberSequence = 3,
                            CompanyId = 1,
                            InUse = true,
                            NbSequence = "FRSI-PO-7402346",
                            Remaining = 75
                        },
                        new
                        {
                            IdNumberSequence = 4,
                            CompanyId = 3,
                            InUse = true,
                            NbSequence = "USMF-PO-8249758",
                            Remaining = 8
                        },
                        new
                        {
                            IdNumberSequence = 5,
                            CompanyId = 2,
                            InUse = true,
                            NbSequence = "DAT-PS-0451257",
                            Remaining = 45
                        },
                        new
                        {
                            IdNumberSequence = 6,
                            CompanyId = 2,
                            InUse = true,
                            NbSequence = "FRSI-SO-0085654",
                            Remaining = 1
                        },
                        new
                        {
                            IdNumberSequence = 7,
                            CompanyId = 1,
                            InUse = true,
                            NbSequence = "FRSI-7402365",
                            Remaining = 75
                        },
                        new
                        {
                            IdNumberSequence = 8,
                            CompanyId = 3,
                            InUse = true,
                            NbSequence = "USMF-8249758",
                            Remaining = 82
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Threshold", b =>
                {
                    b.Property<int>("IdThreshold")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdThreshold"));

                    b.Property<int?>("ThresholdWarnings")
                        .HasColumnType("int");

                    b.HasKey("IdThreshold");

                    b.ToTable("Threshold", (string)null);

                    b.HasData(
                        new
                        {
                            IdThreshold = 1,
                            ThresholdWarnings = 10
                        },
                        new
                        {
                            IdThreshold = 2,
                            ThresholdWarnings = 10
                        },
                        new
                        {
                            IdThreshold = 3,
                            ThresholdWarnings = 10
                        },
                        new
                        {
                            IdThreshold = 4,
                            ThresholdWarnings = 10
                        },
                        new
                        {
                            IdThreshold = 5,
                            ThresholdWarnings = 1
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Tile", b =>
                {
                    b.Property<int>("IdTile")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTile"));

                    b.Property<bool>("Alert")
                        .HasColumnType("bit");

                    b.Property<int>("ModuleDynamicsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Number")
                        .HasColumnType("float");

                    b.Property<int?>("ThresholdId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("IdTile");

                    b.HasIndex("ModuleDynamicsId");

                    b.HasIndex("ThresholdId");

                    b.ToTable("Tiles", (string)null);

                    b.HasData(
                        new
                        {
                            IdTile = 1,
                            Alert = false,
                            ModuleDynamicsId = 1,
                            Name = "Notifications cleanup",
                            Number = 15.0,
                            ThresholdId = 1
                        },
                        new
                        {
                            IdTile = 2,
                            Alert = false,
                            ModuleDynamicsId = 1,
                            Name = "Cleanup batch history custom",
                            Number = 25.0,
                            ThresholdId = 2
                        },
                        new
                        {
                            IdTile = 3,
                            Alert = false,
                            ModuleDynamicsId = 1,
                            Name = "Database cleanup",
                            Number = 89.0,
                            ThresholdId = 3
                        },
                        new
                        {
                            IdTile = 4,
                            Alert = false,
                            ModuleDynamicsId = 2,
                            Name = "Unsent emails",
                            Number = 75.0,
                            ThresholdId = 4
                        },
                        new
                        {
                            IdTile = 5,
                            Alert = false,
                            ModuleDynamicsId = 3,
                            Name = "Due number sequences",
                            ThresholdId = 5
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("DynamicsId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdUser");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            CompanyId = 1,
                            DynamicsId = 6452154,
                            FullName = "Gwendoline Pimprenelle"
                        },
                        new
                        {
                            IdUser = 2,
                            CompanyId = 1,
                            DynamicsId = 2156485,
                            FullName = "Pablo De La Rosa"
                        },
                        new
                        {
                            IdUser = 3,
                            CompanyId = 3,
                            DynamicsId = 9876543,
                            FullName = "Bob the sponge"
                        },
                        new
                        {
                            IdUser = 4,
                            CompanyId = 1,
                            DynamicsId = 2156821,
                            FullName = "Julie Lespine"
                        },
                        new
                        {
                            IdUser = 5,
                            CompanyId = 2,
                            DynamicsId = 7458962,
                            FullName = "Yasmine Sbn Seddick"
                        },
                        new
                        {
                            IdUser = 6,
                            CompanyId = 3,
                            DynamicsId = 9877578,
                            FullName = "Bob the sponge"
                        });
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Cleanup", b =>
                {
                    b.HasOne("MobileMonitoring.Shared.AlertType", "AlertType")
                        .WithMany()
                        .HasForeignKey("AlertTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileMonitoring.Shared.Tile", "Tile")
                        .WithMany()
                        .HasForeignKey("TileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileMonitoring.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AlertType");

                    b.Navigation("Tile");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Email", b =>
                {
                    b.HasOne("MobileMonitoring.Shared.EmailStatus", "EmailStatus")
                        .WithMany()
                        .HasForeignKey("EmailStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MobileMonitoring.Shared.User", "UserReceiver")
                        .WithMany()
                        .HasForeignKey("UserReceiverId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MobileMonitoring.Shared.User", "UserSender")
                        .WithMany()
                        .HasForeignKey("UserSenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("EmailStatus");

                    b.Navigation("UserReceiver");

                    b.Navigation("UserSender");
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Handle", b =>
                {
                    b.HasOne("MobileMonitoring.Shared.Cleanup", "Cleanup")
                        .WithMany()
                        .HasForeignKey("IdCleanup")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MobileMonitoring.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cleanup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MobileMonitoring.Shared.NumberSequence", b =>
                {
                    b.HasOne("MobileMonitoring.Shared.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("MobileMonitoring.Shared.Tile", b =>
                {
                    b.HasOne("MobileMonitoring.Shared.ModuleDynamics", "ModuleDynamics")
                        .WithMany()
                        .HasForeignKey("ModuleDynamicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileMonitoring.Shared.Threshold", "Threshold")
                        .WithMany()
                        .HasForeignKey("ThresholdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuleDynamics");

                    b.Navigation("Threshold");
                });

            modelBuilder.Entity("MobileMonitoring.Shared.User", b =>
                {
                    b.HasOne("MobileMonitoring.Shared.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
