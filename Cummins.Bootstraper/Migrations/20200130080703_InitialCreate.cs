using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cummins.Bootstrapper.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileReference",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileReference", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentProductGroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGroups_ProductGroups_ParentProductGroupId",
                        column: x => x.ParentProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OneWayMileage = table.Column<int>(nullable: false),
                    VehicleTrips = table.Column<int>(nullable: false),
                    AverageMpg = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    ExtendedCost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Kind = table.Column<string>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: true),
                    CreatedById = table.Column<Guid>(nullable: true),
                    UniqueId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elements_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Elements_Employees_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PMAs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TravelItemId = table.Column<Guid>(nullable: true),
                    ServiceBranchId = table.Column<Guid>(nullable: true),
                    DurationOfTheContract = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMAs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PMAs_Branches_ServiceBranchId",
                        column: x => x.ServiceBranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PMAs_TravelItems_TravelItemId",
                        column: x => x.TravelItemId,
                        principalTable: "TravelItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StartTestInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TravelItemId = table.Column<Guid>(nullable: true),
                    BranchId = table.Column<Guid>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    LocationAtSite = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartTestInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartTestInformations_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StartTestInformations_TravelItems_TravelItemId",
                        column: x => x.TravelItemId,
                        principalTable: "TravelItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProductGroupId = table.Column<Guid>(nullable: false),
                    UpfitElementId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Elements_UpfitElementId",
                        column: x => x.UpfitElementId,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpfitRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RFQNotes = table.Column<string>(nullable: true),
                    PassToPurchasing = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SupplierProductNumber = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    PartsCost = table.Column<decimal>(nullable: false),
                    CpPnSku = table.Column<string>(nullable: true),
                    LaborHours = table.Column<decimal>(nullable: false),
                    LaborRate = table.Column<decimal>(nullable: false),
                    LaborCost = table.Column<decimal>(nullable: false),
                    FreightCost = table.Column<decimal>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    SupplierQuoteNo = table.Column<string>(nullable: true),
                    SupplierDrawingLeadTime = table.Column<int>(nullable: false),
                    SupplierLeadTime = table.Column<int>(nullable: false),
                    UpfitElementId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpfitRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpfitRecords_Elements_UpfitElementId",
                        column: x => x.UpfitElementId,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ContractorId = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false),
                    IsShared = table.Column<bool>(nullable: false),
                    IsAccepted = table.Column<bool>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false),
                    AcceptedDateTime = table.Column<DateTime>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    StartTestInformationId = table.Column<Guid>(nullable: true),
                    PMAId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Employees_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Documents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_PMAs_PMAId",
                        column: x => x.PMAId,
                        principalTable: "PMAs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_StartTestInformations_StartTestInformationId",
                        column: x => x.StartTestInformationId,
                        principalTable: "StartTestInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PMAEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    MaterialCost = table.Column<decimal>(nullable: false),
                    AnnualHoursVisit = table.Column<int>(nullable: false),
                    SemiAnnualHoursVisit = table.Column<int>(nullable: false),
                    QuarterlyHoursVisit = table.Column<int>(nullable: false),
                    PMAId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMAEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PMAEntries_PMAs_PMAId",
                        column: x => x.PMAId,
                        principalTable: "PMAs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PMAEntries_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StartTestInformationEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    StartTestInformationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartTestInformationEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartTestInformationEntry_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StartTestInformationEntry_StartTestInformations_StartTestIn~",
                        column: x => x.StartTestInformationId,
                        principalTable: "StartTestInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpfitRecordFileReferencesBindings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpfitRecordId = table.Column<Guid>(nullable: false),
                    FileReferenceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpfitRecordFileReferencesBindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpfitRecordFileReferencesBindings_FileReference_FileReferen~",
                        column: x => x.FileReferenceId,
                        principalTable: "FileReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpfitRecordFileReferencesBindings_UpfitRecords_UpfitRecordId",
                        column: x => x.UpfitRecordId,
                        principalTable: "UpfitRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChangeLogEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ChangeDateTime = table.Column<DateTime>(nullable: false),
                    Reason = table.Column<string>(nullable: false),
                    Order = table.Column<double>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: true),
                    UnderlyingDocumentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLogEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeLogEntries_Employees_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChangeLogEntries_Documents_UnderlyingDocumentId",
                        column: x => x.UnderlyingDocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StartUpRequirements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartTestInformationEntryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartUpRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartUpRequirements_StartTestInformationEntry_StartTestInfo~",
                        column: x => x.StartTestInformationEntryId,
                        principalTable: "StartTestInformationEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChangeLogEntryId = table.Column<Guid>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    ExtendedCost = table.Column<decimal>(nullable: false),
                    SSADiscount = table.Column<decimal>(nullable: false),
                    GrossMargin = table.Column<decimal>(nullable: false),
                    GrossMarginPercent = table.Column<decimal>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    DocumentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentItems_ChangeLogEntries_ChangeLogEntryId",
                        column: x => x.ChangeLogEntryId,
                        principalTable: "ChangeLogEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentItems_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialRequestItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    QuantityToOrder = table.Column<decimal>(nullable: false),
                    CPNo = table.Column<string>(nullable: false),
                    Supplier = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    MaterialRequestId = table.Column<Guid>(nullable: true),
                    PowercomItemId = table.Column<Guid>(nullable: true),
                    UpfitItemId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialRequestItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialRequestItems_MaterialRequests_MaterialRequestId",
                        column: x => x.MaterialRequestId,
                        principalTable: "MaterialRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequestItems_DocumentItems_PowercomItemId",
                        column: x => x.PowercomItemId,
                        principalTable: "DocumentItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialRequestItems_DocumentItems_UpfitItemId",
                        column: x => x.UpfitItemId,
                        principalTable: "DocumentItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PowercomItemBindings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Order = table.Column<double>(nullable: false),
                    PowercomItemId = table.Column<Guid>(nullable: true),
                    PowercomElementId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowercomItemBindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowercomItemBindings_Elements_PowercomElementId",
                        column: x => x.PowercomElementId,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PowercomItemBindings_DocumentItems_PowercomItemId",
                        column: x => x.PowercomItemId,
                        principalTable: "DocumentItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpfitItemBindings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Order = table.Column<double>(nullable: false),
                    UpfitItemId = table.Column<Guid>(nullable: true),
                    UpfitElementId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpfitItemBindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpfitItemBindings_Elements_UpfitElementId",
                        column: x => x.UpfitElementId,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpfitItemBindings_DocumentItems_UpfitItemId",
                        column: x => x.UpfitItemId,
                        principalTable: "DocumentItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChangeLogEntries_ModifiedById",
                table: "ChangeLogEntries",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeLogEntries_UnderlyingDocumentId",
                table: "ChangeLogEntries",
                column: "UnderlyingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentItems_ChangeLogEntryId",
                table: "DocumentItems",
                column: "ChangeLogEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentItems_DocumentId",
                table: "DocumentItems",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ContractorId",
                table: "Documents",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_OwnerId",
                table: "Documents",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ParentId",
                table: "Documents",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ProjectId",
                table: "Documents",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PMAId",
                table: "Documents",
                column: "PMAId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_StartTestInformationId",
                table: "Documents",
                column: "StartTestInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_CategoryId",
                table: "Elements",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_CreatedById",
                table: "Elements",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_UniqueId",
                table: "Elements",
                column: "UniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequestItems_MaterialRequestId",
                table: "MaterialRequestItems",
                column: "MaterialRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequestItems_PowercomItemId",
                table: "MaterialRequestItems",
                column: "PowercomItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequestItems_UpfitItemId",
                table: "MaterialRequestItems",
                column: "UpfitItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PMAEntries_PMAId",
                table: "PMAEntries",
                column: "PMAId");

            migrationBuilder.CreateIndex(
                name: "IX_PMAEntries_ProductId",
                table: "PMAEntries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PMAs_ServiceBranchId",
                table: "PMAs",
                column: "ServiceBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PMAs_TravelItemId",
                table: "PMAs",
                column: "TravelItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PowercomItemBindings_PowercomElementId",
                table: "PowercomItemBindings",
                column: "PowercomElementId");

            migrationBuilder.CreateIndex(
                name: "IX_PowercomItemBindings_PowercomItemId",
                table: "PowercomItemBindings",
                column: "PowercomItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ParentProductGroupId",
                table: "ProductGroups",
                column: "ParentProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UpfitElementId",
                table: "Products",
                column: "UpfitElementId");

            migrationBuilder.CreateIndex(
                name: "IX_StartTestInformationEntry_ProductId",
                table: "StartTestInformationEntry",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StartTestInformationEntry_StartTestInformationId",
                table: "StartTestInformationEntry",
                column: "StartTestInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_StartTestInformations_BranchId",
                table: "StartTestInformations",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StartTestInformations_TravelItemId",
                table: "StartTestInformations",
                column: "TravelItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StartUpRequirements_StartTestInformationEntryId",
                table: "StartUpRequirements",
                column: "StartTestInformationEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_UpfitItemBindings_UpfitElementId",
                table: "UpfitItemBindings",
                column: "UpfitElementId");

            migrationBuilder.CreateIndex(
                name: "IX_UpfitItemBindings_UpfitItemId",
                table: "UpfitItemBindings",
                column: "UpfitItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UpfitRecordFileReferencesBindings_FileReferenceId",
                table: "UpfitRecordFileReferencesBindings",
                column: "FileReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UpfitRecordFileReferencesBindings_UpfitRecordId",
                table: "UpfitRecordFileReferencesBindings",
                column: "UpfitRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_UpfitRecords_UpfitElementId",
                table: "UpfitRecords",
                column: "UpfitElementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialRequestItems");

            migrationBuilder.DropTable(
                name: "PMAEntries");

            migrationBuilder.DropTable(
                name: "PowercomItemBindings");

            migrationBuilder.DropTable(
                name: "StartUpRequirements");

            migrationBuilder.DropTable(
                name: "UpfitItemBindings");

            migrationBuilder.DropTable(
                name: "UpfitRecordFileReferencesBindings");

            migrationBuilder.DropTable(
                name: "MaterialRequests");

            migrationBuilder.DropTable(
                name: "StartTestInformationEntry");

            migrationBuilder.DropTable(
                name: "DocumentItems");

            migrationBuilder.DropTable(
                name: "FileReference");

            migrationBuilder.DropTable(
                name: "UpfitRecords");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ChangeLogEntries");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contractors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "PMAs");

            migrationBuilder.DropTable(
                name: "StartTestInformations");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "TravelItems");
        }
    }
}
