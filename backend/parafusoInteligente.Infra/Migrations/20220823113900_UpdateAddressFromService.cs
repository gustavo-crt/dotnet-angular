using Microsoft.EntityFrameworkCore.Migrations;

namespace parafusoInteligente.Infra.Migrations
{
    public partial class UpdateAddressFromService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ADDRES",
                table: "T_SERVICEORDER",
                newName: "ADDRESS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ADDRESS",
                table: "T_SERVICEORDER",
                newName: "ADDRES");
        }
    }
}
