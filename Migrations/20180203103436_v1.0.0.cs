using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TService.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryProducts",
                columns: table => new
                {
                    delivery_product_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    isCancelled = table.Column<bool>(nullable: false),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true),
                    product_code = table.Column<string>(nullable: true),
                    quantity_number = table.Column<int>(nullable: false),
                    updated_datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryProducts", x => x.delivery_product_id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryWorks",
                columns: table => new
                {
                    delivery_work_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tservice_type_id = table.Column<long>(nullable: false),
                    Tservice_work_id = table.Column<long>(nullable: false),
                    Tservice_work_status_id = table.Column<long>(nullable: false),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    delivery_address_amphur_id = table.Column<long>(nullable: false),
                    delivery_address_details = table.Column<string>(nullable: true),
                    delivery_address_district_id = table.Column<long>(nullable: false),
                    delivery_address_map_google_url = table.Column<string>(nullable: true),
                    delivery_address_map_image_url = table.Column<string>(nullable: true),
                    delivery_address_phone_number = table.Column<string>(nullable: true),
                    delivery_address_place_name = table.Column<string>(nullable: true),
                    delivery_address_province_id = table.Column<long>(nullable: false),
                    delivery_address_receiver_name = table.Column<string>(nullable: true),
                    delivery_address_zip_code = table.Column<int>(nullable: false),
                    delivery_appointed_datetime = table.Column<DateTime>(nullable: false),
                    delivery_distance_kilometre = table.Column<double>(nullable: false),
                    delivery_finished_datetime = table.Column<DateTime>(nullable: false),
                    isCancelled = table.Column<bool>(nullable: false),
                    member_email = table.Column<string>(nullable: true),
                    receipt_number = table.Column<string>(nullable: true),
                    remark_employee = table.Column<string>(nullable: true),
                    remark_member = table.Column<string>(nullable: true),
                    signature_customer_image_url = table.Column<string>(nullable: true),
                    updated_datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryWorks", x => x.delivery_work_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryProducts");

            migrationBuilder.DropTable(
                name: "DeliveryWorks");
        }
    }
}
