using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryProjectTemplate.Migrations
{
    public partial class initGTL10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibraryCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    IssuedDate = table.Column<DateTime>(nullable: false),
                    LibrarianId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryCards_Librarians_LibrarianId",
                        column: x => x.LibrarianId,
                        principalTable: "Librarians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LibraryCards_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_LibrarianId",
                table: "LibraryCards",
                column: "LibrarianId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_MemberId",
                table: "LibraryCards",
                column: "MemberId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryCards");
        }
    }
}
