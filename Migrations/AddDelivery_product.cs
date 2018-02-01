using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace T_Service.Models.Migrations
{
    public partial class AddDelivery_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Delivery_product",
                columns: table => new
                {
                    delivery_product_id = table.Column<int>(type: "long", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameTH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity_number = table.Column<int>(type: "int", nullable: true),
                    isCancelled = table.Column<bool>(type: "bit", nullable: true),
                    created_datetime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    updated_datetime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_product", x => x.delivery_product_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delivery_product");
        }
    }
}
