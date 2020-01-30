﻿// <auto-generated />
using System;
using Cummins.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Cummins.Bootstrapper.Migrations
{
    [DbContext(typeof(CumminsDbContext))]
    [Migration("20200130050347_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Cummins.Model.Base.Contractor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("Cummins.Model.Base.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Cummins.Model.Base.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Cummins.Model.Documents.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Cummins.Model.Documents.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("AcceptedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ContractorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsShared")
                        .HasColumnType("boolean");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ContractorId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ParentId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Documents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Document");
                });

            modelBuilder.Entity("Cummins.Model.Documents.PMA", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("DurationOfTheContract")
                        .HasColumnType("text");

                    b.Property<Guid?>("ServiceBranchId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TravelItemId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ServiceBranchId");

                    b.HasIndex("TravelItemId");

                    b.ToTable("PMAs");
                });

            modelBuilder.Entity("Cummins.Model.Documents.PMAEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AnnualHoursVisit")
                        .HasColumnType("integer");

                    b.Property<decimal>("MaterialCost")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("PMAId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<int>("QuarterlyHoursVisit")
                        .HasColumnType("integer");

                    b.Property<int>("SemiAnnualHoursVisit")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PMAId");

                    b.HasIndex("ProductId");

                    b.ToTable("PMAEntries");
                });

            modelBuilder.Entity("Cummins.Model.Documents.StartTestInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("BranchId")
                        .HasColumnType("uuid");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("LocationAtSite")
                        .HasColumnType("text");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("TravelItemId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("TravelItemId");

                    b.ToTable("StartTestInformations");
                });

            modelBuilder.Entity("Cummins.Model.Documents.StartTestInformationEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Initials")
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("StartTestInformationId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StartTestInformationId");

                    b.ToTable("StartTestInformationEntry");
                });

            modelBuilder.Entity("Cummins.Model.Documents.StartUpRequirement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("StartTestInformationEntryId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("StartTestInformationEntryId");

                    b.ToTable("StartUpRequirements");
                });

            modelBuilder.Entity("Cummins.Model.Documents.TravelItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AverageMpg")
                        .HasColumnType("integer");

                    b.Property<int>("OneWayMileage")
                        .HasColumnType("integer");

                    b.Property<int>("VehicleTrips")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TravelItems");
                });

            modelBuilder.Entity("Cummins.Model.Elements.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Cummins.Model.Elements.Element", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("ExtendedCost")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Elements");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Element");
                });

            modelBuilder.Entity("Cummins.Model.Elements.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("ProductGroupId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UpfitElementId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductGroupId");

                    b.HasIndex("UpfitElementId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Cummins.Model.Elements.ProductGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("ParentProductGroupId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ParentProductGroupId");

                    b.ToTable("ProductGroups");
                });

            modelBuilder.Entity("Cummins.Model.Elements.UpfitRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("CpPnSku")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<decimal>("FreightCost")
                        .HasColumnType("numeric");

                    b.Property<decimal>("LaborCost")
                        .HasColumnType("numeric");

                    b.Property<decimal>("LaborHours")
                        .HasColumnType("numeric");

                    b.Property<decimal>("LaborRate")
                        .HasColumnType("numeric");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<decimal>("PartsCost")
                        .HasColumnType("numeric");

                    b.Property<bool>("PassToPurchasing")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<string>("RFQNotes")
                        .HasColumnType("text");

                    b.Property<int>("SupplierDrawingLeadTime")
                        .HasColumnType("integer");

                    b.Property<int>("SupplierLeadTime")
                        .HasColumnType("integer");

                    b.Property<string>("SupplierName")
                        .HasColumnType("text");

                    b.Property<string>("SupplierProductNumber")
                        .HasColumnType("text");

                    b.Property<string>("SupplierQuoteNo")
                        .HasColumnType("text");

                    b.Property<Guid?>("UpfitElementId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UpfitElementId");

                    b.ToTable("UpfitRecords");
                });

            modelBuilder.Entity("Cummins.Model.Items.ChangeLogEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ChangeDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Order")
                        .HasColumnType("double precision");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UnderlyingDocumentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("UnderlyingDocumentId");

                    b.ToTable("ChangeLogEntries");
                });

            modelBuilder.Entity("Cummins.Model.Items.DocumentItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ChangeLogEntryId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("DocumentId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ExtendedCost")
                        .HasColumnType("numeric");

                    b.Property<decimal>("GrossMargin")
                        .HasColumnType("numeric");

                    b.Property<decimal>("GrossMarginPercent")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SSADiscount")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ChangeLogEntryId");

                    b.HasIndex("DocumentId");

                    b.ToTable("DocumentItems");

                    b.HasDiscriminator<string>("Discriminator").HasValue("DocumentItem");
                });

            modelBuilder.Entity("Cummins.Model.Items.MaterialRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("MaterialRequests");
                });

            modelBuilder.Entity("Cummins.Model.Items.MaterialRequestItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CPNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("MaterialRequestId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("QuantityToOrder")
                        .HasColumnType("numeric");

                    b.Property<string>("Supplier")
                        .HasColumnType("text");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("MaterialRequestId");

                    b.ToTable("MaterialRequestItems");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MaterialRequestItem");
                });

            modelBuilder.Entity("Cummins.Model.Items.PowercomItemBinding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Order")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("PowercomElementId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PowercomItemId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PowercomElementId");

                    b.HasIndex("PowercomItemId");

                    b.ToTable("PowercomItemBindings");
                });

            modelBuilder.Entity("Cummins.Model.Items.UpfitItemBinding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Order")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("UpfitElementId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UpfitItemId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UpfitElementId");

                    b.HasIndex("UpfitItemId");

                    b.ToTable("UpfitItemBindings");
                });

            modelBuilder.Entity("Cummins.Model.Documents.BOM", b =>
                {
                    b.HasBaseType("Cummins.Model.Documents.Document");

                    b.HasDiscriminator().HasValue("BOM");
                });

            modelBuilder.Entity("Cummins.Model.Documents.ChangeOrder", b =>
                {
                    b.HasBaseType("Cummins.Model.Documents.Document");

                    b.HasDiscriminator().HasValue("ChangeOrder");
                });

            modelBuilder.Entity("Cummins.Model.Documents.Quote", b =>
                {
                    b.HasBaseType("Cummins.Model.Documents.Document");

                    b.Property<Guid>("PMAId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StartTestInformationId")
                        .HasColumnType("uuid");

                    b.HasIndex("PMAId");

                    b.HasIndex("StartTestInformationId");

                    b.HasDiscriminator().HasValue("Quote");
                });

            modelBuilder.Entity("Cummins.Model.Elements.PowercomElement", b =>
                {
                    b.HasBaseType("Cummins.Model.Elements.Element");

                    b.HasDiscriminator().HasValue("PowercomElement");
                });

            modelBuilder.Entity("Cummins.Model.Elements.UpfitElement", b =>
                {
                    b.HasBaseType("Cummins.Model.Elements.Element");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uuid");

                    b.Property<string>("Kind")
                        .HasColumnType("text");

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UniqueId")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("UpfitElement");
                });

            modelBuilder.Entity("Cummins.Model.Items.PowercomItem", b =>
                {
                    b.HasBaseType("Cummins.Model.Items.DocumentItem");

                    b.HasDiscriminator().HasValue("PowercomItem");
                });

            modelBuilder.Entity("Cummins.Model.Items.UpfitItem", b =>
                {
                    b.HasBaseType("Cummins.Model.Items.DocumentItem");

                    b.HasDiscriminator().HasValue("UpfitItem");
                });

            modelBuilder.Entity("Cummins.Model.Items.PowercomMaterialRequestItem", b =>
                {
                    b.HasBaseType("Cummins.Model.Items.MaterialRequestItem");

                    b.Property<Guid?>("PowercomItemId")
                        .HasColumnType("uuid");

                    b.HasIndex("PowercomItemId");

                    b.HasDiscriminator().HasValue("PowercomMaterialRequestItem");
                });

            modelBuilder.Entity("Cummins.Model.Items.UpfitMaterialRequestItem", b =>
                {
                    b.HasBaseType("Cummins.Model.Items.MaterialRequestItem");

                    b.Property<Guid?>("UpfitItemId")
                        .HasColumnType("uuid");

                    b.HasIndex("UpfitItemId");

                    b.HasDiscriminator().HasValue("UpfitMaterialRequestItem");
                });

            modelBuilder.Entity("Cummins.Model.Documents.Document", b =>
                {
                    b.HasOne("Cummins.Model.Base.Contractor", "Contractor")
                        .WithMany()
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cummins.Model.Base.Employee", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cummins.Model.Documents.Document", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("Cummins.Model.Base.Project", "Project")
                        .WithMany("Documents")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cummins.Model.Documents.PMA", b =>
                {
                    b.HasOne("Cummins.Model.Documents.Branch", "ServiceBranch")
                        .WithMany()
                        .HasForeignKey("ServiceBranchId");

                    b.HasOne("Cummins.Model.Documents.TravelItem", "TravelItem")
                        .WithMany()
                        .HasForeignKey("TravelItemId");
                });

            modelBuilder.Entity("Cummins.Model.Documents.PMAEntry", b =>
                {
                    b.HasOne("Cummins.Model.Documents.PMA", null)
                        .WithMany("PMAEntries")
                        .HasForeignKey("PMAId");

                    b.HasOne("Cummins.Model.Elements.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cummins.Model.Documents.StartTestInformation", b =>
                {
                    b.HasOne("Cummins.Model.Documents.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("Cummins.Model.Documents.TravelItem", "TravelItem")
                        .WithMany()
                        .HasForeignKey("TravelItemId");
                });

            modelBuilder.Entity("Cummins.Model.Documents.StartTestInformationEntry", b =>
                {
                    b.HasOne("Cummins.Model.Elements.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cummins.Model.Documents.StartTestInformation", null)
                        .WithMany("StartTestInformationItems")
                        .HasForeignKey("StartTestInformationId");
                });

            modelBuilder.Entity("Cummins.Model.Documents.StartUpRequirement", b =>
                {
                    b.HasOne("Cummins.Model.Documents.StartTestInformationEntry", null)
                        .WithMany("StartUpRequirements")
                        .HasForeignKey("StartTestInformationEntryId");
                });

            modelBuilder.Entity("Cummins.Model.Elements.Product", b =>
                {
                    b.HasOne("Cummins.Model.Elements.ProductGroup", "ProductGroup")
                        .WithMany("Products")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cummins.Model.Elements.UpfitElement", null)
                        .WithMany("Products")
                        .HasForeignKey("UpfitElementId");
                });

            modelBuilder.Entity("Cummins.Model.Elements.ProductGroup", b =>
                {
                    b.HasOne("Cummins.Model.Elements.ProductGroup", "ParentProductGroup")
                        .WithMany()
                        .HasForeignKey("ParentProductGroupId");
                });

            modelBuilder.Entity("Cummins.Model.Elements.UpfitRecord", b =>
                {
                    b.HasOne("Cummins.Model.Elements.UpfitElement", null)
                        .WithMany("UpfitRecords")
                        .HasForeignKey("UpfitElementId");

                    b.OwnsMany("Cummins.Model.Elements.FileReference", "FileReferences", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<Guid>("EntityId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Name")
                                .HasColumnType("text");

                            b1.Property<string>("Url")
                                .HasColumnType("text");

                            b1.HasKey("Id");

                            b1.HasIndex("EntityId");

                            b1.ToTable("FileReferences");

                            b1.WithOwner()
                                .HasForeignKey("EntityId");
                        });
                });

            modelBuilder.Entity("Cummins.Model.Items.ChangeLogEntry", b =>
                {
                    b.HasOne("Cummins.Model.Base.Employee", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Cummins.Model.Documents.Document", "UnderlyingDocument")
                        .WithMany()
                        .HasForeignKey("UnderlyingDocumentId");
                });

            modelBuilder.Entity("Cummins.Model.Items.DocumentItem", b =>
                {
                    b.HasOne("Cummins.Model.Items.ChangeLogEntry", "ChangeLogEntry")
                        .WithMany()
                        .HasForeignKey("ChangeLogEntryId");

                    b.HasOne("Cummins.Model.Documents.Document", null)
                        .WithMany("Items")
                        .HasForeignKey("DocumentId");
                });

            modelBuilder.Entity("Cummins.Model.Items.MaterialRequestItem", b =>
                {
                    b.HasOne("Cummins.Model.Items.MaterialRequest", null)
                        .WithMany("MaterialRequestItems")
                        .HasForeignKey("MaterialRequestId");
                });

            modelBuilder.Entity("Cummins.Model.Items.PowercomItemBinding", b =>
                {
                    b.HasOne("Cummins.Model.Elements.PowercomElement", "PowercomElement")
                        .WithMany()
                        .HasForeignKey("PowercomElementId");

                    b.HasOne("Cummins.Model.Items.PowercomItem", "PowercomItem")
                        .WithMany()
                        .HasForeignKey("PowercomItemId");
                });

            modelBuilder.Entity("Cummins.Model.Items.UpfitItemBinding", b =>
                {
                    b.HasOne("Cummins.Model.Elements.UpfitElement", "UpfitElement")
                        .WithMany()
                        .HasForeignKey("UpfitElementId");

                    b.HasOne("Cummins.Model.Items.UpfitItem", "UpfitItem")
                        .WithMany()
                        .HasForeignKey("UpfitItemId");
                });

            modelBuilder.Entity("Cummins.Model.Documents.Quote", b =>
                {
                    b.HasOne("Cummins.Model.Documents.PMA", "PMA")
                        .WithMany()
                        .HasForeignKey("PMAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cummins.Model.Documents.StartTestInformation", "StartTestInformation")
                        .WithMany()
                        .HasForeignKey("StartTestInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cummins.Model.Elements.UpfitElement", b =>
                {
                    b.HasOne("Cummins.Model.Elements.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cummins.Model.Base.Employee", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");
                });

            modelBuilder.Entity("Cummins.Model.Items.PowercomMaterialRequestItem", b =>
                {
                    b.HasOne("Cummins.Model.Items.PowercomItem", "PowercomItem")
                        .WithMany()
                        .HasForeignKey("PowercomItemId");
                });

            modelBuilder.Entity("Cummins.Model.Items.UpfitMaterialRequestItem", b =>
                {
                    b.HasOne("Cummins.Model.Items.UpfitItem", "UpfitItem")
                        .WithMany()
                        .HasForeignKey("UpfitItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
