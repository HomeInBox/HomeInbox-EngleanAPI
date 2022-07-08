using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeInbox_EngleanAPI.Migrations
{
    public partial class CreateTableUserlogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CREATE_DATE",
                table: "vocabularies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UPDATE_DATE",
                table: "vocabularies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "userlogins",
                columns: table => new
                {
                    AGGREGATEID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USERNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userlogins", x => x.AGGREGATEID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userlogins");

            migrationBuilder.DropColumn(
                name: "CREATE_DATE",
                table: "vocabularies");

            migrationBuilder.DropColumn(
                name: "UPDATE_DATE",
                table: "vocabularies");
        }
    }
}
