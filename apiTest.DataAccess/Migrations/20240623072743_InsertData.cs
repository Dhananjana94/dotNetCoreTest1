using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiTest.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InsertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TstMdlTble",
                columns: new[] { "Id", "CreatedDate", "Description", "Status", "Title", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 6, 23, 12, 57, 42, 764, DateTimeKind.Local).AddTicks(2242), "testing model 1", 0, "Test model 1", new DateTime(2024, 6, 28, 12, 57, 42, 764, DateTimeKind.Local).AddTicks(2257) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
