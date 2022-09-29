using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace parafusoInteligente.Infra.Migrations
{
    public partial class BusinessAndReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_BUSINESSRULES",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RULE = table.Column<string>(type: "text", nullable: true),
                    GROUPS_TO_APPLY = table.Column<string>(type: "text", nullable: true),
                    PERMISSIONS = table.Column<string>(type: "text", nullable: true),
                    HOUR_TO_APPLY = table.Column<string>(type: "text", nullable: true),
                    REGION = table.Column<string>(type: "text", nullable: true),
                    KEYS_TO_APPLY = table.Column<string>(type: "text", nullable: true),
                    SCREWS_TO_APPLY = table.Column<string>(type: "text", nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_BUSINESSRULES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_REPORT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IDENTIFIER = table.Column<string>(type: "text", nullable: true),
                    USERNAME = table.Column<string>(type: "text", nullable: true),
                    DATE_TIME_SYNC = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ACTION = table.Column<string>(type: "text", nullable: true),
                    REGION = table.Column<string>(type: "text", nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_REPORT", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_BUSINESSRULES");

            migrationBuilder.DropTable(
                name: "T_REPORT");
        }
    }
}
