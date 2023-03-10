// <auto-generated />
using System;
using Ecommerce_MVC_Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce_MVC_Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230117163455_allTable")]
    partial class allTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<double>("Charge");

                    b.Property<int>("CityId");

                    b.Property<string>("Latitude")
                        .HasMaxLength(100);

                    b.Property<string>("Longditude")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Pram")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<double>("Rate");

                    b.Property<string>("Remarks")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("DeliveryAddress")
                        .HasMaxLength(200);

                    b.Property<double>("DeliveryCharge");

                    b.Property<int>("LocationId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Number")
                        .HasMaxLength(100);

                    b.Property<double>("OthersCharge");

                    b.Property<int>("PaymentMethodId");

                    b.Property<double>("Total");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2023, 1, 17, 22, 34, 55, 875, DateTimeKind.Local));

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Note");

                    b.Property<int>("OrderId");

                    b.Property<int>("StatusId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Processor");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Description");

                    b.Property<int>("Discount");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<double>("Price");

                    b.Property<string>("Tag")
                        .HasMaxLength(200);

                    b.Property<int>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductComments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Comment")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<string>("UserId");

                    b.Property<int?>("UsersId1");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.HasIndex("UsersId1");

                    b.ToTable("ProductComments");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("ImagePath");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductLikes", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<string>("UserId");

                    b.Property<DateTime>("AddedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2023, 1, 17, 22, 34, 55, 863, DateTimeKind.Local));

                    b.Property<string>("UsersId");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UsersId");

                    b.ToTable("ProductLikes");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductManual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("ManualName");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductManual");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("InQuantity");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("OutQuantity");

                    b.Property<int>("ProductId");

                    b.Property<string>("Remarks")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductStock");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Level")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.UserLoginHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("IpAddress");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("UserId");

                    b.Property<int?>("UsersId");

                    b.Property<string>("UsersId1");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.HasIndex("UsersId1");

                    b.ToTable("UserLoginHistory");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Address");

                    b.Property<int>("CityId");

                    b.Property<string>("Contact");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("JoinIp");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.ApplicationRoles", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("IpAddress");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.ApplicationUsers", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<int?>("CityId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Contact");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Gender");

                    b.Property<string>("JoinIp");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Refference");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Category", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Category", "Categoris")
                        .WithMany("CategoriesList")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.City", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Location", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.City", "City")
                        .WithMany("Locations")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.OrderDetails", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Orders", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Orders", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Location", "Location")
                        .WithMany("Orderses")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.PaymentMethod", "PaymentMethod")
                        .WithMany("Orderses")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers", "Users")
                        .WithMany("Orderses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.OrderStatus", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Orders", "Orders")
                        .WithMany("OrderStatus")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Status", "Status")
                        .WithMany("OrderStatus")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers", "Users")
                        .WithMany("OrderStatuses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Product", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Unit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductComments", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Product", "Product")
                        .WithMany("ProductCommentses")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers", "Users")
                        .WithMany("ProductCommentses")
                        .HasForeignKey("UserId");

                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Users")
                        .WithMany("ProductCommentses")
                        .HasForeignKey("UsersId1");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductImage", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductLikes", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductManual", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Product", "Product")
                        .WithOne("ProductManual")
                        .HasForeignKey("Ecommerce_MVC_Core.Models.Admin.ProductManual", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.ProductStock", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Product", "Product")
                        .WithMany("ProductStocks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.UserLoginHistory", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.Users")
                        .WithMany("UserLoginHistories")
                        .HasForeignKey("UsersId");

                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId1");
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.Admin.Users", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce_MVC_Core.Models.ApplicationUsers", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.Admin.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationRoles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationRoles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ecommerce_MVC_Core.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
