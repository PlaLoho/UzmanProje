using Microsoft.EntityFrameworkCore.Migrations;

namespace UzmanLaundry.Data.Migrations
{
    public partial class Nullable_islemID_Requirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musteriler_Islem_islemID",
                table: "Musteriler");

            migrationBuilder.AlterColumn<int>(
                name: "islemID",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "firmaAdi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "islemTuru",
                table: "Islem",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Musteriler_Islem_islemID",
                table: "Musteriler",
                column: "islemID",
                principalTable: "Islem",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musteriler_Islem_islemID",
                table: "Musteriler");

            migrationBuilder.AlterColumn<int>(
                name: "islemID",
                table: "Musteriler",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firmaAdi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "islemTuru",
                table: "Islem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Musteriler_Islem_islemID",
                table: "Musteriler",
                column: "islemID",
                principalTable: "Islem",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
