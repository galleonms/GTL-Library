using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryProjectTemplate.Migrations
{
    public partial class newGtl05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BookISBN",
                table: "AuthorBook",
                column: "BookISBN");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Authors_AuthorId",
                table: "AuthorBook",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_BookISBN",
                table: "AuthorBook",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_AuthorId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_BookISBN",
                table: "AuthorBook");

            migrationBuilder.DropIndex(
                name: "IX_AuthorBook_BookISBN",
                table: "AuthorBook");
        }
    }
}
