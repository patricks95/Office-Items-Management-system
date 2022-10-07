using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNISD.Migrations
{
    public partial class add_tables_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaultReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DoneBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaultReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaultReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaultReports_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaultReports_ShopDetails_ShopDetailId",
                        column: x => x.ShopDetailId,
                        principalTable: "ShopDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FaultReports_EmployeeId",
                table: "FaultReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FaultReports_ItemId",
                table: "FaultReports",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FaultReports_ShopDetailId",
                table: "FaultReports",
                column: "ShopDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaultReports");

            migrationBuilder.DropTable(
                name: "ShopDetails");
        }
    }
}
