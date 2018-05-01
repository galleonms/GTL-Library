using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryProjectTemplate.Migrations
{
    public partial class newGtl06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoadId",
                table: "LibrarianLoans",
                newName: "LoanId");

            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "Librarians",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Librarians",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Librarians",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibrarianLoans_LibrarianId",
                table: "LibrarianLoans",
                column: "LibrarianId");

            migrationBuilder.AddForeignKey(
                name: "FK_LibrarianLoans_Librarians_LibrarianId",
                table: "LibrarianLoans",
                column: "LibrarianId",
                principalTable: "Librarians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LibrarianLoans_Loans_LoanId",
                table: "LibrarianLoans",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibrarianLoans_Librarians_LibrarianId",
                table: "LibrarianLoans");

            migrationBuilder.DropForeignKey(
                name: "FK_LibrarianLoans_Loans_LoanId",
                table: "LibrarianLoans");

            migrationBuilder.DropIndex(
                name: "IX_LibrarianLoans_LibrarianId",
                table: "LibrarianLoans");

            migrationBuilder.RenameColumn(
                name: "LoanId",
                table: "LibrarianLoans",
                newName: "LoadId");

            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "Librarians",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Librarians",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Librarians",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
