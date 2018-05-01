using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryProjectTemplate.Migrations
{
    public partial class initGTL11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryCards_Members_MemberId",
                table: "LibraryCards");

            migrationBuilder.DropIndex(
                name: "IX_LibraryCards_MemberId",
                table: "LibraryCards");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "LibraryCards",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryCards_Members_Id",
                table: "LibraryCards",
                column: "Id",
                principalTable: "Members",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryCards_Members_Id",
                table: "LibraryCards");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "LibraryCards",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_MemberId",
                table: "LibraryCards",
                column: "MemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryCards_Members_MemberId",
                table: "LibraryCards",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
