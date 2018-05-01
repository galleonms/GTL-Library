using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryProjectTemplate.Migrations
{
    public partial class initGTL15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryCards_Members_Id",
                table: "LibraryCards");

            migrationBuilder.AddColumn<int>(
                name: "LibraryCardForeignKey",
                table: "Members",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "LibraryCards",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Members_LibraryCardForeignKey",
                table: "Members",
                column: "LibraryCardForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_LibraryCards_LibraryCardForeignKey",
                table: "Members",
                column: "LibraryCardForeignKey",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_LibraryCards_LibraryCardForeignKey",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_LibraryCardForeignKey",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "LibraryCardForeignKey",
                table: "Members");

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
    }
}
