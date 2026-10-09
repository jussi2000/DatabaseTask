using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baggages",
                columns: table => new
                {
                    Baggage_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Baggage_Tag_Nr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baggage_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baggages", x => x.Baggage_ID);
                });

            migrationBuilder.CreateTable(
                name: "FlightStatuses",
                columns: table => new
                {
                    FlightStatus_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Flight_status_change = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time_change = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightStatuses", x => x.FlightStatus_ID);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Registration_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Registration_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ticket_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Registration_ID);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Flight_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Flight_Nr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departure_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Departure_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Passanger_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightStatus_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Flight_ID);
                    table.ForeignKey(
                        name: "FK_Flights_FlightStatuses_FlightStatus_ID",
                        column: x => x.FlightStatus_ID,
                        principalTable: "FlightStatuses",
                        principalColumn: "FlightStatus_ID");
                });

            migrationBuilder.CreateTable(
                name: "Passangers",
                columns: table => new
                {
                    Passanger_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Identification_Nr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registration_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Baggage_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Registration_ID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passangers", x => x.Passanger_ID);
                    table.ForeignKey(
                        name: "FK_Passangers_Baggages_Baggage_ID",
                        column: x => x.Baggage_ID,
                        principalTable: "Baggages",
                        principalColumn: "Baggage_ID");
                    table.ForeignKey(
                        name: "FK_Passangers_Registrations_Registration_ID1",
                        column: x => x.Registration_ID1,
                        principalTable: "Registrations",
                        principalColumn: "Registration_ID");
                });

            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    Aircraft_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Registration_Nr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seat_Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year_Of_Manufaceture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.Aircraft_ID);
                    table.ForeignKey(
                        name: "FK_Aircrafts_Flights_Flight_ID",
                        column: x => x.Flight_ID,
                        principalTable: "Flights",
                        principalColumn: "Flight_ID");
                });

            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    Airline_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.Airline_ID);
                    table.ForeignKey(
                        name: "FK_Airlines_Flights_Flight_ID",
                        column: x => x.Flight_ID,
                        principalTable: "Flights",
                        principalColumn: "Flight_ID");
                });

            migrationBuilder.CreateTable(
                name: "Gates",
                columns: table => new
                {
                    Gate_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gate_Nr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    max_aircraft_size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    min_aircraft_size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Flight_ID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gates", x => x.Gate_ID);
                    table.ForeignKey(
                        name: "FK_Gates_Flights_Flight_ID1",
                        column: x => x.Flight_ID1,
                        principalTable: "Flights",
                        principalColumn: "Flight_ID");
                });

            migrationBuilder.CreateTable(
                name: "FlightPassanger",
                columns: table => new
                {
                    FlightsFlight_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PassangersPassanger_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassanger", x => new { x.FlightsFlight_ID, x.PassangersPassanger_ID });
                    table.ForeignKey(
                        name: "FK_FlightPassanger_Flights_FlightsFlight_ID",
                        column: x => x.FlightsFlight_ID,
                        principalTable: "Flights",
                        principalColumn: "Flight_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassanger_Passangers_PassangersPassanger_ID",
                        column: x => x.PassangersPassanger_ID,
                        principalTable: "Passangers",
                        principalColumn: "Passanger_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Airport_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Flight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passenger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aircraft = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baggage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Airline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Airline_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Airport_ID);
                    table.ForeignKey(
                        name: "FK_Airports_Airlines_Airline_ID",
                        column: x => x.Airline_ID,
                        principalTable: "Airlines",
                        principalColumn: "Airline_ID");
                });

            migrationBuilder.CreateTable(
                name: "Terminals",
                columns: table => new
                {
                    Terminal_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Terminal_Nr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gate_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminals", x => x.Terminal_ID);
                    table.ForeignKey(
                        name: "FK_Terminals_Gates_Gate_ID",
                        column: x => x.Gate_ID,
                        principalTable: "Gates",
                        principalColumn: "Gate_ID");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Nr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Terminal_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employees_Terminals_Terminal_ID",
                        column: x => x.Terminal_ID,
                        principalTable: "Terminals",
                        principalColumn: "Terminal_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_Flight_ID",
                table: "Aircrafts",
                column: "Flight_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Airlines_Flight_ID",
                table: "Airlines",
                column: "Flight_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_Airline_ID",
                table: "Airports",
                column: "Airline_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Terminal_ID",
                table: "Employees",
                column: "Terminal_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassanger_PassangersPassanger_ID",
                table: "FlightPassanger",
                column: "PassangersPassanger_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_FlightStatus_ID",
                table: "Flights",
                column: "FlightStatus_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Gates_Flight_ID1",
                table: "Gates",
                column: "Flight_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Passangers_Baggage_ID",
                table: "Passangers",
                column: "Baggage_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Passangers_Registration_ID1",
                table: "Passangers",
                column: "Registration_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Terminals_Gate_ID",
                table: "Terminals",
                column: "Gate_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "FlightPassanger");

            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.DropTable(
                name: "Terminals");

            migrationBuilder.DropTable(
                name: "Passangers");

            migrationBuilder.DropTable(
                name: "Gates");

            migrationBuilder.DropTable(
                name: "Baggages");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "FlightStatuses");
        }
    }
}
