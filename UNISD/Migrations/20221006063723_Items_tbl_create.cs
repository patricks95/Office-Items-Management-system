using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNISD.Migrations
{
    public partial class Items_tbl_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gen = table.Column<int>(type: "int", nullable: false),
                    Ram = table.Column<int>(type: "int", nullable: false),
                    RamType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RamSpeed = table.Column<int>(type: "int", nullable: false),
                    Ssd = table.Column<int>(type: "int", nullable: false),
                    Hdd = table.Column<int>(type: "int", nullable: false),
                    PurchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    warrantyYear = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
