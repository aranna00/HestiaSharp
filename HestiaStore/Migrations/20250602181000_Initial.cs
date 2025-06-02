using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HestiaStore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "chats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Filter = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dwelling_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dwelling_types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "energy_labels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_energy_labels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    GemeenteId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cities_locations_GemeenteId",
                        column: x => x.GemeenteId,
                        principalTable: "locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_cities_locations_Id",
                        column: x => x.Id,
                        principalTable: "locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "homes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostalCode = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    Street = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    HouseNumber = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    HouseNumberAddition = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    AgencyId = table.Column<int>(type: "integer", nullable: false),
                    SolarPanels = table.Column<bool>(type: "boolean", nullable: true),
                    GasLess = table.Column<bool>(type: "boolean", nullable: true),
                    ZeroOnTheMeter = table.Column<bool>(type: "boolean", nullable: true),
                    AvailableFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TotalPrice = table.Column<int>(type: "integer", nullable: false),
                    NewlyBuild = table.Column<bool>(type: "boolean", nullable: false),
                    LivinArea = table.Column<int>(type: "integer", nullable: true),
                    HasGarden = table.Column<bool>(type: "boolean", nullable: false),
                    HasBalcony = table.Column<bool>(type: "boolean", nullable: false),
                    HasStorageRoom = table.Column<bool>(type: "boolean", nullable: false),
                    MunicipalityId = table.Column<int>(type: "integer", nullable: true),
                    DwellingTypeId = table.Column<int>(type: "integer", nullable: true),
                    EnergyLabelId = table.Column<int>(type: "integer", nullable: true),
                    Rooms = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_homes_agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_homes_cities_CityId",
                        column: x => x.CityId,
                        principalTable: "cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_homes_dwelling_types_DwellingTypeId",
                        column: x => x.DwellingTypeId,
                        principalTable: "dwelling_types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_homes_energy_labels_EnergyLabelId",
                        column: x => x.EnergyLabelId,
                        principalTable: "energy_labels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_homes_locations_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "target_groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    MinAge = table.Column<int>(type: "integer", nullable: true),
                    MaxAge = table.Column<int>(type: "integer", nullable: true),
                    AidHome = table.Column<bool>(type: "boolean", nullable: true),
                    MinimumOccupants = table.Column<int>(type: "integer", nullable: true),
                    MaximumOccupants = table.Column<int>(type: "integer", nullable: true),
                    HomeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_target_groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_target_groups_homes_HomeId",
                        column: x => x.HomeId,
                        principalTable: "homes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cities_GemeenteId",
                table: "cities",
                column: "GemeenteId");

            migrationBuilder.CreateIndex(
                name: "IX_homes_AgencyId",
                table: "homes",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_homes_CityId",
                table: "homes",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_homes_DwellingTypeId",
                table: "homes",
                column: "DwellingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_homes_EnergyLabelId",
                table: "homes",
                column: "EnergyLabelId");

            migrationBuilder.CreateIndex(
                name: "IX_homes_MunicipalityId",
                table: "homes",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_target_groups_HomeId",
                table: "target_groups",
                column: "HomeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chats");

            migrationBuilder.DropTable(
                name: "target_groups");

            migrationBuilder.DropTable(
                name: "homes");

            migrationBuilder.DropTable(
                name: "agencies");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "dwelling_types");

            migrationBuilder.DropTable(
                name: "energy_labels");

            migrationBuilder.DropTable(
                name: "locations");
        }
    }
}
