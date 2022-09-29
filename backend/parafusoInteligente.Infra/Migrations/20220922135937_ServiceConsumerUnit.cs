using Microsoft.EntityFrameworkCore.Migrations;

namespace parafusoInteligente.Infra.Migrations
{
    public partial class ServiceConsumerUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ID_CONSUMER_UNIT",
                table: "T_SERVICEORDER",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_T_SERVICEORDER_ID_CONSUMER_UNIT",
                table: "T_SERVICEORDER",
                column: "ID_CONSUMER_UNIT");

            migrationBuilder.AddForeignKey(
                name: "FK_T_SERVICEORDER_T_CONSUMERUNIT_ID_CONSUMER_UNIT",
                table: "T_SERVICEORDER",
                column: "ID_CONSUMER_UNIT",
                principalTable: "T_CONSUMERUNIT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_SERVICEORDER_T_CONSUMERUNIT_ID_CONSUMER_UNIT",
                table: "T_SERVICEORDER");

            migrationBuilder.DropIndex(
                name: "IX_T_SERVICEORDER_ID_CONSUMER_UNIT",
                table: "T_SERVICEORDER");

            migrationBuilder.DropColumn(
                name: "ID_CONSUMER_UNIT",
                table: "T_SERVICEORDER");
        }
    }
}
