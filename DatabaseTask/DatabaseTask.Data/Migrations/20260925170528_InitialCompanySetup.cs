using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCompanySetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Costumer_ID = table.Column<int>(type: "int", nullable: true),
                    Child_ID = table.Column<int>(type: "int", nullable: true),
                    First_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contact_e_mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contact_phone_number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                });

            migrationBuilder.CreateTable(
                name: "Items_owned_by_company",
                columns: table => new
                {
                    Items_owned_by_company_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items_owned_by_company", x => x.Items_owned_by_company_ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Service_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Service_ID);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Child_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_ID = table.Column<int>(type: "int", nullable: true),
                    First_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Child_ID);
                    table.ForeignKey(
                        name: "FK_Children_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID");
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Company_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_ID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Company_ID);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID");
                });

            migrationBuilder.CreateTable(
                name: "HealthCares",
                columns: table => new
                {
                    HealthCare_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_ID = table.Column<int>(type: "int", nullable: true),
                    Absentee_reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    History = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCares", x => x.HealthCare_ID);
                    table.ForeignKey(
                        name: "FK_HealthCares_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID");
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Rank_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_ID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Rank_ID);
                    table.ForeignKey(
                        name: "FK_Ranks_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID");
                });

            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    Borrows_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Items_owned_by_company_ID = table.Column<int>(type: "int", nullable: true),
                    Employee_ID = table.Column<int>(type: "int", nullable: true),
                    Borrowing_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Borrowing_start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Borrowing_end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    History = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.Borrows_ID);
                    table.ForeignKey(
                        name: "FK_Borrows_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID");
                    table.ForeignKey(
                        name: "FK_Borrows_Items_owned_by_company_Items_owned_by_company_ID",
                        column: x => x.Items_owned_by_company_ID,
                        principalTable: "Items_owned_by_company",
                        principalColumn: "Items_owned_by_company_ID");
                });

            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    Costumer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_ID = table.Column<int>(type: "int", nullable: true),
                    First_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contact_e_mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contact_phone_number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Service_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.Costumer_ID);
                    table.ForeignKey(
                        name: "FK_Costumers_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Costumers_Services_Service_ID",
                        column: x => x.Service_ID,
                        principalTable: "Services",
                        principalColumn: "Service_ID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeService",
                columns: table => new
                {
                    EmployeesEmployee_ID = table.Column<int>(type: "int", nullable: false),
                    ServicesService_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeService", x => new { x.EmployeesEmployee_ID, x.ServicesService_ID });
                    table.ForeignKey(
                        name: "FK_EmployeeService_Employees_EmployeesEmployee_ID",
                        column: x => x.EmployeesEmployee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeService_Services_ServicesService_ID",
                        column: x => x.ServicesService_ID,
                        principalTable: "Services",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyService",
                columns: table => new
                {
                    CompaniesCompany_ID = table.Column<int>(type: "int", nullable: false),
                    ServicesService_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyService", x => new { x.CompaniesCompany_ID, x.ServicesService_ID });
                    table.ForeignKey(
                        name: "FK_CompanyService_Companies_CompaniesCompany_ID",
                        column: x => x.CompaniesCompany_ID,
                        principalTable: "Companies",
                        principalColumn: "Company_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyService_Services_ServicesService_ID",
                        column: x => x.ServicesService_ID,
                        principalTable: "Services",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Intranets",
                columns: table => new
                {
                    Intranet_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_ID = table.Column<int>(type: "int", nullable: true),
                    Employee_ID = table.Column<int>(type: "int", nullable: true),
                    Borrows_ID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intranets", x => x.Intranet_ID);
                    table.ForeignKey(
                        name: "FK_Intranets_Borrows_Borrows_ID",
                        column: x => x.Borrows_ID,
                        principalTable: "Borrows",
                        principalColumn: "Borrows_ID");
                    table.ForeignKey(
                        name: "FK_Intranets_Companies_Company_ID",
                        column: x => x.Company_ID,
                        principalTable: "Companies",
                        principalColumn: "Company_ID");
                    table.ForeignKey(
                        name: "FK_Intranets_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_Employee_ID",
                table: "Borrows",
                column: "Employee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_Items_owned_by_company_ID",
                table: "Borrows",
                column: "Items_owned_by_company_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Children_Employee_ID",
                table: "Children",
                column: "Employee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Employee_ID",
                table: "Companies",
                column: "Employee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyService_ServicesService_ID",
                table: "CompanyService",
                column: "ServicesService_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Costumers_Employee_ID",
                table: "Costumers",
                column: "Employee_ID",
                unique: true,
                filter: "[Employee_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Costumers_Service_ID",
                table: "Costumers",
                column: "Service_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeService_ServicesService_ID",
                table: "EmployeeService",
                column: "ServicesService_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCares_Employee_ID",
                table: "HealthCares",
                column: "Employee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Intranets_Borrows_ID",
                table: "Intranets",
                column: "Borrows_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Intranets_Company_ID",
                table: "Intranets",
                column: "Company_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Intranets_Employee_ID",
                table: "Intranets",
                column: "Employee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ranks_Employee_ID",
                table: "Ranks",
                column: "Employee_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "CompanyService");

            migrationBuilder.DropTable(
                name: "Costumers");

            migrationBuilder.DropTable(
                name: "EmployeeService");

            migrationBuilder.DropTable(
                name: "HealthCares");

            migrationBuilder.DropTable(
                name: "Intranets");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Items_owned_by_company");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
