﻿// <auto-generated />
using System;
using CustomerManagement.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerManagement.Data.Migrations
{
    [DbContext(typeof(CRMDbContext))]
    partial class CRMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerManagement.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Logo = "/brands-logo/subaru2019.png",
                            Name = "Subaru"
                        },
                        new
                        {
                            Id = 2,
                            Logo = "/brands-logo/mazda2019.png",
                            Name = "Mazda"
                        });
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.CarCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("CarCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Name = "Outback"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            Name = "Forester"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            Name = "XV"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 2,
                            Name = "Mazda 2"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 2,
                            Name = "Mazda 3"
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 2,
                            Name = "Mazda 6"
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 2,
                            Name = "CX-5"
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 2,
                            Name = "BT50"
                        });
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.CarColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("HEX")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CarCategoryId");

                    b.ToTable("CarColors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarCategoryId = 1,
                            EnglishName = "Tungsten",
                            HEX = "FFFFFF",
                            Name = "Vàng cát"
                        },
                        new
                        {
                            Id = 2,
                            CarCategoryId = 1,
                            EnglishName = "Crystal Black",
                            HEX = "000000",
                            Name = "Đen Huyền Bí"
                        },
                        new
                        {
                            Id = 3,
                            CarCategoryId = 1,
                            EnglishName = "Gray Blue",
                            HEX = "FFFFFF",
                            Name = "Xanh xám"
                        },
                        new
                        {
                            Id = 4,
                            CarCategoryId = 2,
                            EnglishName = "Crystal Black",
                            HEX = "FFFFFF",
                            Name = "Đen Huyền Bí"
                        },
                        new
                        {
                            Id = 5,
                            CarCategoryId = 2,
                            EnglishName = "Crystal White Pearl",
                            HEX = "000000",
                            Name = "Trắng Ngọc Trai"
                        },
                        new
                        {
                            Id = 6,
                            CarCategoryId = 2,
                            EnglishName = "Horizontal Blue Pearl",
                            HEX = "FFFFFF",
                            Name = "Xanh dương"
                        },
                        new
                        {
                            Id = 7,
                            CarCategoryId = 3,
                            EnglishName = "Orange",
                            HEX = "FFFFFF",
                            Name = "Vàng cam"
                        },
                        new
                        {
                            Id = 8,
                            CarCategoryId = 4,
                            EnglishName = "Crystal Black",
                            HEX = "FFFFFF",
                            Name = "Đen Huyền Bí"
                        },
                        new
                        {
                            Id = 9,
                            CarCategoryId = 5,
                            EnglishName = "Crystal White Pearl",
                            HEX = "000000",
                            Name = "Trắng Ngọc Trai"
                        },
                        new
                        {
                            Id = 10,
                            CarCategoryId = 6,
                            EnglishName = "Horizontal Blue Pearl",
                            HEX = "FFFFFF",
                            Name = "Xanh dương"
                        },
                        new
                        {
                            Id = 11,
                            CarCategoryId = 7,
                            EnglishName = "Crystal Black",
                            HEX = "FFFFFF",
                            Name = "Đen Huyền Bí"
                        },
                        new
                        {
                            Id = 12,
                            CarCategoryId = 8,
                            EnglishName = "Crystal White Pearl",
                            HEX = "000000",
                            Name = "Trắng Ngọc Trai"
                        },
                        new
                        {
                            Id = 13,
                            CarCategoryId = 8,
                            EnglishName = "Horizontal Blue Pearl",
                            HEX = "FFFFFF",
                            Name = "Xanh dương"
                        });
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.CarEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarColorId")
                        .HasColumnType("int");

                    b.Property<int>("CarModelId")
                        .HasColumnType("int");

                    b.Property<string>("EngineNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PurchasePrice")
                        .HasColumnType("bigint");

                    b.Property<long>("SalePrice")
                        .HasColumnType("bigint");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarEntities");
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("GearBox")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("MY")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long>("OriginalPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L);

                    b.Property<int>("YOM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("CarModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Engine = "Boxer H4 2.5",
                            GearBox = "Lineartronic CVT",
                            MY = 2020,
                            Name = "Outback 2.5 ES 2020",
                            OriginalPrice = 1868000000L,
                            YOM = 2020
                        },
                        new
                        {
                            Id = 2,
                            Engine = "Boxer H4 2.0",
                            GearBox = "Lineartronic CVT",
                            MY = 2019,
                            Name = "Forester iL 2020",
                            OriginalPrice = 1128000000L,
                            YOM = 2020
                        },
                        new
                        {
                            Id = 3,
                            Engine = "Boxer H4 2.0",
                            GearBox = "Lineartronic CVT",
                            MY = 2019,
                            Name = "Forester iS 2020",
                            OriginalPrice = 1218000000L,
                            YOM = 2020
                        },
                        new
                        {
                            Id = 4,
                            Engine = "Boxer H4 2.0",
                            GearBox = "Lineartronic CVT",
                            MY = 2020,
                            Name = "Forester iS ES 2020",
                            OriginalPrice = 1288000000L,
                            YOM = 2020
                        },
                        new
                        {
                            Id = 5,
                            Engine = "Boxer H4 2.0",
                            GearBox = "Lineartronic CVT",
                            MY = 2019,
                            Name = "Forester iL 2019",
                            OriginalPrice = 1128000000L,
                            YOM = 2019
                        },
                        new
                        {
                            Id = 6,
                            Engine = "Boxer H4 2.0",
                            GearBox = "Lineartronic CVT",
                            MY = 2019,
                            Name = "Forester iS 2019",
                            OriginalPrice = 1218000000L,
                            YOM = 2019
                        },
                        new
                        {
                            Id = 7,
                            Engine = "Boxer H4 2.0",
                            GearBox = "Lineartronic CVT",
                            MY = 2019,
                            Name = "Forester iS ES 2019",
                            OriginalPrice = 1288000000L,
                            YOM = 2019
                        },
                        new
                        {
                            Id = 8,
                            Engine = "Boxer H4 2.0",
                            GearBox = "Lineartronic CVT",
                            MY = 2019,
                            Name = "XV ES 2019",
                            OriginalPrice = 1516000000L,
                            YOM = 2019
                        });
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.CarModelCategory", b =>
                {
                    b.Property<int>("CarCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CarModelId")
                        .HasColumnType("int");

                    b.HasKey("CarCategoryId", "CarModelId");

                    b.HasIndex("CarModelId");

                    b.ToTable("CarModelCategories");

                    b.HasData(
                        new
                        {
                            CarCategoryId = 1,
                            CarModelId = 1
                        },
                        new
                        {
                            CarCategoryId = 2,
                            CarModelId = 2
                        },
                        new
                        {
                            CarCategoryId = 2,
                            CarModelId = 3
                        },
                        new
                        {
                            CarCategoryId = 2,
                            CarModelId = 4
                        },
                        new
                        {
                            CarCategoryId = 2,
                            CarModelId = 5
                        },
                        new
                        {
                            CarCategoryId = 2,
                            CarModelId = 6
                        },
                        new
                        {
                            CarCategoryId = 2,
                            CarModelId = 7
                        },
                        new
                        {
                            CarCategoryId = 3,
                            CarModelId = 8
                        });
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4c3e1c7f-e15c-4fb9-ba91-4de8015ed313",
                            DoB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@subarukimson.vn",
                            EmailConfirmed = true,
                            FirstName = "Tiến",
                            Gender = 0,
                            JoinDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Phan Ngọc",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@subarukimson.vn",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAENKna5z8OUPEaOd/CVpsZ+o2JpLfjz1OUz1mihgjkn3BXhXjLfpD3x5taM+kSKD5Pg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin",
                            YearOfExperience = 0
                        });
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.EmployeePosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("EmployeePositions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "7fe41aa3-6010-49a3-b020-2c49f5ce3a8d",
                            Level = 0,
                            Name = "Adminstrator",
                            NormalizedName = "adminstrator"
                        });
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.SystemActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FunctionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SystemActivities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EmployeePositionClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EmployeeClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("EmployeeLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("EmployeePositionEmployees");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("EmployeeTokens");
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.CarCategory", b =>
                {
                    b.HasOne("CustomerManagement.Data.Entities.Brand", "Brand")
                        .WithMany("CarCategories")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.CarColor", b =>
                {
                    b.HasOne("CustomerManagement.Data.Entities.CarCategory", "CarCategory")
                        .WithMany("CarColors")
                        .HasForeignKey("CarCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.CarModelCategory", b =>
                {
                    b.HasOne("CustomerManagement.Data.Entities.CarCategory", "CarCategory")
                        .WithMany("CarModelCategories")
                        .HasForeignKey("CarCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerManagement.Data.Entities.CarModel", "CarModel")
                        .WithMany("CarModelCategories")
                        .HasForeignKey("CarModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerManagement.Data.Entities.EmployeePosition", b =>
                {
                    b.HasOne("CustomerManagement.Data.Entities.EmployeePosition", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
