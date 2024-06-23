using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace apiTest.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "TstMdlTble",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Wasantha perera" },
                    { 2, "Wasthi anushka" },
                    { 3, "Sumanapala herath" }
                });

            migrationBuilder.UpdateData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 6, 23, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8605), "Test model 1 from sql", new DateTime(2024, 6, 28, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.InsertData(
                table: "TstMdlTble",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2024, 6, 23, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8625), "testing model 2", 0, "Test model 2", new DateTime(2024, 6, 28, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8625) },
                    { 3, 2, new DateTime(2024, 6, 23, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8627), "testing model 3", 0, "Test model 3", new DateTime(2024, 6, 28, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8628) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TstMdlTble_AuthorId",
                table: "TstMdlTble",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TstMdlTble_Authors_AuthorId",
                table: "TstMdlTble",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TstMdlTble_Authors_AuthorId",
                table: "TstMdlTble");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_TstMdlTble_AuthorId",
                table: "TstMdlTble");

            migrationBuilder.DeleteData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "TstMdlTble");

            migrationBuilder.UpdateData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 12, 57, 42, 764, DateTimeKind.Local).AddTicks(2242), "Test model 1", new DateTime(2024, 6, 28, 12, 57, 42, 764, DateTimeKind.Local).AddTicks(2257) });
        }
    }
}
