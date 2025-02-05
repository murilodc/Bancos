using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TesteTecnicoBancos.Infrastructure.Migrations
{
    public partial class FixKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boletos_Banks_BankId",
                table: "Boletos");

            migrationBuilder.DropIndex(
                name: "IX_Boletos_BankId",
                table: "Boletos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Banks",
                table: "Banks");

            migrationBuilder.AddColumn<int>(
                name: "BankCode",
                table: "Boletos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "BankId1",
                table: "Boletos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Banks",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Banks",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banks",
                table: "Banks",
                columns: new[] { "Id", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_Boletos_BankId1_BankCode",
                table: "Boletos",
                columns: new[] { "BankId1", "BankCode" });

            migrationBuilder.AddForeignKey(
                name: "FK_Boletos_Banks_BankId1_BankCode",
                table: "Boletos",
                columns: new[] { "BankId1", "BankCode" },
                principalTable: "Banks",
                principalColumns: new[] { "Id", "Code" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boletos_Banks_BankId1_BankCode",
                table: "Boletos");

            migrationBuilder.DropIndex(
                name: "IX_Boletos_BankId1_BankCode",
                table: "Boletos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Banks",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "BankCode",
                table: "Boletos");

            migrationBuilder.DropColumn(
                name: "BankId1",
                table: "Boletos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Banks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Banks",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banks",
                table: "Banks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Boletos_BankId",
                table: "Boletos",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boletos_Banks_BankId",
                table: "Boletos",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
