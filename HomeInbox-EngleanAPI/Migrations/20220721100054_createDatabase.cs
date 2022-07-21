using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeInbox_EngleanAPI.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "vocabularies",
                columns: table => new
                {
                    AGGREGATEID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VOCABULARY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEANING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VOCABULARYTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vocabularies", x => x.AGGREGATEID);
                });

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

            migrationBuilder.CreateTable(
                name: "TESTSCOREs",
                columns: table => new
                {
                    AGGREGATEID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCORE = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NO = table.Column<int>(type: "int", nullable: false),
                    AGGREGATEIDUSERPROFILE = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TESTSCOREs", x => x.AGGREGATEID);
                    table.ForeignKey(
                        name: "FK_TESTSCOREs_userProfiles_AGGREGATEIDUSERPROFILE",
                        column: x => x.AGGREGATEIDUSERPROFILE,
                        principalTable: "userProfiles",
                        principalColumn: "AGGREGATEID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TESTSCOREs_AGGREGATEIDUSERPROFILE",
                table: "TESTSCOREs",
                column: "AGGREGATEIDUSERPROFILE");

            migrationBuilder.CreateIndex(
                name: "IX_userProfiles_AGGREGATEIDUSERLOGIN",
                table: "userProfiles",
                column: "AGGREGATEIDUSERLOGIN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TESTSCOREs");

            migrationBuilder.DropTable(
                name: "vocabularies");

            migrationBuilder.DropTable(
                name: "userProfiles");

            migrationBuilder.DropTable(
                name: "userlogins");
        }
    }
}
