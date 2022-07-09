using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeInbox_EngleanAPI.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userProfiles",
                columns: table => new
                {
                    AGGREGATEID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AGGREGATEIDUSERLOGIN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userProfiles", x => x.AGGREGATEID);
                    table.ForeignKey(
                        name: "FK_userProfiles_userlogins_AGGREGATEIDUSERLOGIN",
                        column: x => x.AGGREGATEIDUSERLOGIN,
                        principalTable: "userlogins",
                        principalColumn: "AGGREGATEID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userProfiles_AGGREGATEIDUSERLOGIN",
                table: "userProfiles",
                column: "AGGREGATEIDUSERLOGIN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userProfiles");
        }
    }
}
