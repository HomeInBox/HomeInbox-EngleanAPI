using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeInbox_EngleanAPI.Migrations
{
    public partial class AdjustNameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TESTSCOREs_userProfiles_AGGREGATEIDUSERPROFILE",
                table: "TESTSCOREs");

            migrationBuilder.DropTable(
                name: "userProfiles");

            migrationBuilder.DropTable(
                name: "userlogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vocabularies",
                table: "vocabularies");

            migrationBuilder.RenameTable(
                name: "vocabularies",
                newName: "VOCABULARYs");

            migrationBuilder.RenameColumn(
                name: "VOCABULARY",
                table: "VOCABULARYs",
                newName: "VOCABULARYs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VOCABULARYs",
                table: "VOCABULARYs",
                column: "AGGREGATEID");

            migrationBuilder.CreateTable(
                name: "USER_LOGINs",
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
                    table.PrimaryKey("PK_USER_LOGINs", x => x.AGGREGATEID);
                });

            migrationBuilder.CreateTable(
                name: "USER_PROFILEs",
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
                    table.PrimaryKey("PK_USER_PROFILEs", x => x.AGGREGATEID);
                    table.ForeignKey(
                        name: "FK_USER_PROFILEs_USER_LOGINs_AGGREGATEIDUSERLOGIN",
                        column: x => x.AGGREGATEIDUSERLOGIN,
                        principalTable: "USER_LOGINs",
                        principalColumn: "AGGREGATEID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_USER_PROFILEs_AGGREGATEIDUSERLOGIN",
                table: "USER_PROFILEs",
                column: "AGGREGATEIDUSERLOGIN",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TESTSCOREs_USER_PROFILEs_AGGREGATEIDUSERPROFILE",
                table: "TESTSCOREs",
                column: "AGGREGATEIDUSERPROFILE",
                principalTable: "USER_PROFILEs",
                principalColumn: "AGGREGATEID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TESTSCOREs_USER_PROFILEs_AGGREGATEIDUSERPROFILE",
                table: "TESTSCOREs");

            migrationBuilder.DropTable(
                name: "USER_PROFILEs");

            migrationBuilder.DropTable(
                name: "USER_LOGINs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VOCABULARYs",
                table: "VOCABULARYs");

            migrationBuilder.RenameTable(
                name: "VOCABULARYs",
                newName: "vocabularies");

            migrationBuilder.RenameColumn(
                name: "VOCABULARYs",
                table: "vocabularies",
                newName: "VOCABULARY");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vocabularies",
                table: "vocabularies",
                column: "AGGREGATEID");

            migrationBuilder.CreateTable(
                name: "userlogins",
                columns: table => new
                {
                    AGGREGATEID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USERNAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userlogins", x => x.AGGREGATEID);
                });

            migrationBuilder.CreateTable(
                name: "userProfiles",
                columns: table => new
                {
                    AGGREGATEID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AGGREGATEIDUSERLOGIN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.AddForeignKey(
                name: "FK_TESTSCOREs_userProfiles_AGGREGATEIDUSERPROFILE",
                table: "TESTSCOREs",
                column: "AGGREGATEIDUSERPROFILE",
                principalTable: "userProfiles",
                principalColumn: "AGGREGATEID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
