using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace parafusoInteligente.Infra.Migrations
{
    public partial class ServiceOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_SERVICEORDER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    OS = table.Column<int>(type: "integer", nullable: false),
                    SERVICE = table.Column<string>(type: "text", nullable: true),
                    ADDRES = table.Column<string>(type: "text", nullable: true),
                    METER = table.Column<string>(type: "text", nullable: true),
                    CDC = table.Column<string>(type: "text", nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SERVICEORDER", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_SERVICEORDER");
        }
    }
}
