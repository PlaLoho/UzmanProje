using Microsoft.EntityFrameworkCore.Migrations;

namespace UzmanLaundry.Data.Migrations
{
    public partial class Islem_NullAble_Silme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musteriler_Islem_islemID",
                table: "Musteriler");

            migrationBuilder.AlterColumn<int>(
                name: "islemID",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Musteriler_Islem_islemID",
                table: "Musteriler",
                column: "islemID",
                principalTable: "Islem",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
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
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Musteriler_Islem_islemID",
                table: "Musteriler",
                column: "islemID",
                principalTable: "Islem",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
