using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HestiaStore.Migrations
{
    /// <inheritdoc />
    public partial class StructureUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_target_groups_homes_HomeId",
                table: "target_groups");

            migrationBuilder.DropIndex(
                name: "IX_target_groups_HomeId",
                table: "target_groups");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "target_groups");

            migrationBuilder.CreateTable(
                name: "HomeTargetGroup",
                columns: table => new
                {
                    HomeId = table.Column<int>(type: "integer", nullable: false),
                    TargetGroupsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTargetGroup", x => new { x.HomeId, x.TargetGroupsId });
                    table.ForeignKey(
                        name: "FK_HomeTargetGroup_homes_HomeId",
                        column: x => x.HomeId,
                        principalTable: "homes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeTargetGroup_target_groups_TargetGroupsId",
                        column: x => x.TargetGroupsId,
                        principalTable: "target_groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomeTargetGroup_TargetGroupsId",
                table: "HomeTargetGroup",
                column: "TargetGroupsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeTargetGroup");

            migrationBuilder.AddColumn<int>(
                name: "HomeId",
                table: "target_groups",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_target_groups_HomeId",
                table: "target_groups",
                column: "HomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_target_groups_homes_HomeId",
                table: "target_groups",
                column: "HomeId",
                principalTable: "homes",
                principalColumn: "Id");
        }
    }
}
