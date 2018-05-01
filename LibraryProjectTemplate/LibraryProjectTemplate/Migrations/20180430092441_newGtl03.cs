using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryProjectTemplate.Migrations
{
    public partial class newGtl03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanItem");

            migrationBuilder.RenameColumn(
                name: "LoanDate",
                table: "Loans",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Books",
                newName: "Binding");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "AuthorBook",
                newName: "BookISBN");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Loans",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GracePeriod",
                table: "Loans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemberSSN",
                table: "Loans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "CanBeLoaned",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CopiesAvailable",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Edition",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Books",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LibraryCode",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LoanId",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnLoan",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Books",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Century",
                table: "Authors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LibrarianLoans",
                columns: table => new
                {
                    LoadId = table.Column<int>(nullable: false),
                    LibrarianId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibrarianLoans", x => new { x.LoadId, x.LibrarianId });
                });

            migrationBuilder.CreateTable(
                name: "Librarians",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarians", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_LoanId",
                table: "Books",
                column: "LoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Loans_LoanId",
                table: "Books",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Loans_LoanId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "LibrarianLoans");

            migrationBuilder.DropTable(
                name: "Librarians");

            migrationBuilder.DropIndex(
                name: "IX_Books_LoanId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "GracePeriod",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "MemberSSN",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "CanBeLoaned",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CopiesAvailable",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Edition",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LibraryCode",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "OnLoan",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Century",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Loans",
                newName: "LoanDate");

            migrationBuilder.RenameColumn(
                name: "Binding",
                table: "Books",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookISBN",
                table: "AuthorBook",
                newName: "BookId");

            migrationBuilder.CreateTable(
                name: "LoanItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: true),
                    LoanId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanItem_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanItem_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanItem_BookId",
                table: "LoanItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanItem_LoanId",
                table: "LoanItem",
                column: "LoanId");
        }
    }
}
