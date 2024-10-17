using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiTest.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataannotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TstMdlTble",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TstMdlTble",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Authors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "Street" },
                values: new object[] { "dibulagala", "Galpola", "60 para" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "Street" },
                values: new object[] { "Raththota", "thota", "30 para" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "Street" },
                values: new object[] { "Galgamuwa", "muwa", "20 para" });

            migrationBuilder.UpdateData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 17, 46, 53, 448, DateTimeKind.Local).AddTicks(5369), new DateTime(2024, 7, 5, 17, 46, 53, 448, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 17, 46, 53, 448, DateTimeKind.Local).AddTicks(5391), new DateTime(2024, 7, 5, 17, 46, 53, 448, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 17, 46, 53, 448, DateTimeKind.Local).AddTicks(5394), new DateTime(2024, 7, 5, 17, 46, 53, 448, DateTimeKind.Local).AddTicks(5394) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TstMdlTble",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TstMdlTble",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8605), new DateTime(2024, 6, 28, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 6, 28, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "TstMdlTble",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8627), new DateTime(2024, 6, 28, 17, 17, 2, 603, DateTimeKind.Local).AddTicks(8628) });
        }
    }
}
