﻿// <auto-generated />
using System;
using AkCadeMic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AkCadeMic.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AkCadeMic.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("isAdmin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AkCadeMic.Models.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreadId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ThreadId");

                    b.HasIndex("UserId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("AkCadeMic.Models.ReplyH", b =>
                {
                    b.Property<int>("IdH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TextH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreadIdH")
                        .HasColumnType("int");

                    b.Property<string>("UserHId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdH");

                    b.HasIndex("ThreadIdH");

                    b.HasIndex("UserHId");

                    b.ToTable("RepliesH");
                });

            modelBuilder.Entity("AkCadeMic.Models.ReplyO", b =>
                {
                    b.Property<int>("IdO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TextO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreadIdO")
                        .HasColumnType("int");

                    b.Property<string>("UserOId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdO");

                    b.HasIndex("ThreadIdO");

                    b.HasIndex("UserOId");

                    b.ToTable("RepliesO");
                });

            modelBuilder.Entity("AkCadeMic.Models.ReplyS", b =>
                {
                    b.Property<int>("IdS")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TextS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreadIdS")
                        .HasColumnType("int");

                    b.Property<string>("UserSId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdS");

                    b.HasIndex("ThreadIdS");

                    b.HasIndex("UserSId");

                    b.ToTable("RepliesS");
                });

            modelBuilder.Entity("AkCadeMic.Models.Thread", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadH", b =>
                {
                    b.Property<int>("PostIdH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserHId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostIdH");

                    b.HasIndex("UserHId");

                    b.ToTable("ThreadsH");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadJ", b =>
                {
                    b.Property<int>("PostIdJ")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostIdJ");

                    b.ToTable("ThreadsJ");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadO", b =>
                {
                    b.Property<int>("PostIdO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserOId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostIdO");

                    b.HasIndex("UserOId");

                    b.ToTable("ThreadsO");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadS", b =>
                {
                    b.Property<int>("PostIdS")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostIdS");

                    b.HasIndex("UserSId");

                    b.ToTable("ThreadsS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AkCadeMic.Models.Reply", b =>
                {
                    b.HasOne("AkCadeMic.Models.Thread", "Thread")
                        .WithMany("Replies")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AkCadeMic.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Thread");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AkCadeMic.Models.ReplyH", b =>
                {
                    b.HasOne("AkCadeMic.Models.ThreadH", "ThreadH")
                        .WithMany("RepliesH")
                        .HasForeignKey("ThreadIdH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AkCadeMic.Models.ApplicationUser", "UserH")
                        .WithMany()
                        .HasForeignKey("UserHId");

                    b.Navigation("ThreadH");

                    b.Navigation("UserH");
                });

            modelBuilder.Entity("AkCadeMic.Models.ReplyO", b =>
                {
                    b.HasOne("AkCadeMic.Models.ThreadO", "ThreadO")
                        .WithMany("RepliesO")
                        .HasForeignKey("ThreadIdO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AkCadeMic.Models.ApplicationUser", "UserO")
                        .WithMany()
                        .HasForeignKey("UserOId");

                    b.Navigation("ThreadO");

                    b.Navigation("UserO");
                });

            modelBuilder.Entity("AkCadeMic.Models.ReplyS", b =>
                {
                    b.HasOne("AkCadeMic.Models.ThreadS", "ThreadS")
                        .WithMany("RepliesS")
                        .HasForeignKey("ThreadIdS")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AkCadeMic.Models.ApplicationUser", "UserS")
                        .WithMany()
                        .HasForeignKey("UserSId");

                    b.Navigation("ThreadS");

                    b.Navigation("UserS");
                });

            modelBuilder.Entity("AkCadeMic.Models.Thread", b =>
                {
                    b.HasOne("AkCadeMic.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadH", b =>
                {
                    b.HasOne("AkCadeMic.Models.ApplicationUser", "UserH")
                        .WithMany()
                        .HasForeignKey("UserHId");

                    b.Navigation("UserH");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadO", b =>
                {
                    b.HasOne("AkCadeMic.Models.ApplicationUser", "UserO")
                        .WithMany()
                        .HasForeignKey("UserOId");

                    b.Navigation("UserO");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadS", b =>
                {
                    b.HasOne("AkCadeMic.Models.ApplicationUser", "UserS")
                        .WithMany()
                        .HasForeignKey("UserSId");

                    b.Navigation("UserS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AkCadeMic.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AkCadeMic.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AkCadeMic.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AkCadeMic.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AkCadeMic.Models.Thread", b =>
                {
                    b.Navigation("Replies");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadH", b =>
                {
                    b.Navigation("RepliesH");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadO", b =>
                {
                    b.Navigation("RepliesO");
                });

            modelBuilder.Entity("AkCadeMic.Models.ThreadS", b =>
                {
                    b.Navigation("RepliesS");
                });
#pragma warning restore 612, 618
        }
    }
}
