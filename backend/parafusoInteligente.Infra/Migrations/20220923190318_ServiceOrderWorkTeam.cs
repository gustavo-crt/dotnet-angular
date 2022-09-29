using Microsoft.EntityFrameworkCore.Migrations;

namespace parafusoInteligente.Infra.Migrations
{
    public partial class ServiceOrderWorkTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ID_WORK_TEAM",
                table: "T_SERVICEORDER",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_T_SERVICEORDER_ID_WORK_TEAM",
                table: "T_SERVICEORDER",
                column: "ID_WORK_TEAM");

            migrationBuilder.AddForeignKey(
                name: "FK_T_SERVICEORDER_T_WORK_TEAM_ID_WORK_TEAM",
                table: "T_SERVICEORDER",
                column: "ID_WORK_TEAM",
                principalTable: "T_WORK_TEAM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_SERVICEORDER_T_WORK_TEAM_ID_WORK_TEAM",
                table: "T_SERVICEORDER");

            migrationBuilder.DropIndex(
                name: "IX_T_SERVICEORDER_ID_WORK_TEAM",
                table: "T_SERVICEORDER");

            migrationBuilder.DropColumn(
                name: "ID_WORK_TEAM",
                table: "T_SERVICEORDER");
        }
    }
}
