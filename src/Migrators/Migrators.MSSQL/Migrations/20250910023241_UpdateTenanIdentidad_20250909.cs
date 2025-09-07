using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Blazor.Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTenanIdentidad_20250909 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TenantIdentidades_Logo",
                table: "TenantIdentidades");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "TenantIdentidades");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "TenantIdentidades");

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "TenantIdentidades",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantLogo",
                table: "TenantIdentidades",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantLogo",
                table: "TenantIdentidades");

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "TenantIdentidades",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "TenantIdentidades",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "TenantIdentidades",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TenantIdentidades_Logo",
                table: "TenantIdentidades",
                column: "Logo");
        }
    }
}
