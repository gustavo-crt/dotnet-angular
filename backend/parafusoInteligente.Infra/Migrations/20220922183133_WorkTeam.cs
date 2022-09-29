using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace parafusoInteligente.Infra.Migrations
{
    public partial class WorkTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_SYNC");

            migrationBuilder.CreateTable(
                name: "T_WORK_TEAM",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TEAM = table.Column<string>(type: "text", nullable: false),
                    USERS = table.Column<string>(type: "text", nullable: false),
                    SCREWS = table.Column<string>(type: "text", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_WORK_TEAM", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_WORK_TEAM");

            migrationBuilder.CreateTable(
                name: "T_SYNC",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CREATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    GROUP = table.Column<string>(type: "text", nullable: false),
                    SCREWS = table.Column<string>(type: "text", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SYNC", x => x.ID);
                });
        }
    }
}
