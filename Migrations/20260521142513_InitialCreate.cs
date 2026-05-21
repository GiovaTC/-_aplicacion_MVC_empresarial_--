using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMVCOracle.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRODUCTOS_O",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOMBRE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    PRECIO = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    STOCK = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTOS_O", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUCTOS_O");
        }
    }
}
