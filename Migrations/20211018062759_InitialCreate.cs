using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBankloan.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bisInfoDetails",
                columns: table => new
                {
                    RefID = table.Column<string>(type: "varchar(255)", nullable: false),
                    Cifno = table.Column<string>(type: "varchar(255)", nullable: true),
                    signature = table.Column<string>(type: "varchar(255)", nullable: true),
                    sourceCode = table.Column<string>(type: "varchar(255)", nullable: true),
                    type = table.Column<string>(type: "varchar(255)", nullable: true),
                    businessNo = table.Column<string>(type: "varchar(255)", nullable: true),
                    businessName = table.Column<string>(type: "varchar(255)", nullable: true),
                    businessAddress = table.Column<string>(type: "varchar(255)", nullable: true),
                    businessEmail = table.Column<string>(type: "varchar(255)", nullable: true),
                    businessPhoneNo = table.Column<string>(type: "varchar(255)", nullable: true),
                    initiatorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    contactPerson = table.Column<string>(type: "varchar(255)", nullable: true),
                    contactPhoneNo = table.Column<string>(type: "varchar(255)", nullable: true),
                    roleID = table.Column<string>(type: "varchar(255)", nullable: true),
                    reqBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    status = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bisInfoDetails", x => x.RefID);
                });

            migrationBuilder.CreateTable(
                name: "Authorizers",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<string>(type: "varchar(255)", nullable: true),
                    userName = table.Column<string>(type: "varchar(255)", nullable: true),
                    userEmail = table.Column<string>(type: "varchar(255)", nullable: true),
                    userPhoneNo = table.Column<string>(type: "varchar(255)", nullable: true),
                    status = table.Column<string>(type: "varchar(255)", nullable: false),
                    RefID = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorizers", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Authorizers_bisInfoDetails_RefID",
                        column: x => x.RefID,
                        principalTable: "bisInfoDetails",
                        principalColumn: "RefID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authorizers_RefID",
                table: "Authorizers",
                column: "RefID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authorizers");

            migrationBuilder.DropTable(
                name: "bisInfoDetails");
        }
    }
}
