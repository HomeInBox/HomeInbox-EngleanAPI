using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeInbox_EngleanAPI.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vocabularies",
                columns: table => new
                {
                    AGGREGATEID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VOCABULARY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEANING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VOCABULARYTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vocabularies", x => x.AGGREGATEID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vocabularies");
        }
    }
}
