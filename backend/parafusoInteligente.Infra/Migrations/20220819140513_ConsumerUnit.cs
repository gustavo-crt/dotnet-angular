using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace parafusoInteligente.Infra.Migrations
{
    public partial class ConsumerUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_CONSUMERUNIT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CONSUMER_GROUP = table.Column<string>(type: "text", nullable: true),
                    COORDINATES = table.Column<string>(type: "text", nullable: true),
                    ADDRES = table.Column<string>(type: "text", nullable: true),
                    METER_CODE = table.Column<int>(type: "integer", nullable: false),
                    SCREWS = table.Column<string>(type: "text", nullable: true),
                    REGION = table.Column<string>(type: "text", nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CONSUMERUNIT", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_CONSUMERUNIT");
        }
    }
}
