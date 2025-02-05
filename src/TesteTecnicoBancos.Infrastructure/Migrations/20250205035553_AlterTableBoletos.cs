using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteTecnicoBancos.Infrastructure.Migrations
{
    public partial class AlterTableBoletos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CPFCNPJ",
                table: "Boletos",
                newName: "RecipientName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Boletos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<string>(
                name: "PayeeCpfCnpj",
                table: "Boletos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecipientCpfCnpj",
                table: "Boletos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayeeCpfCnpj",
                table: "Boletos");

            migrationBuilder.DropColumn(
                name: "RecipientCpfCnpj",
                table: "Boletos");

            migrationBuilder.RenameColumn(
                name: "RecipientName",
                table: "Boletos",
                newName: "CPFCNPJ");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DueDate",
                table: "Boletos",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }
    }
}
