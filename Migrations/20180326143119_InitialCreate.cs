using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryProducts",
                columns: table => new
                {
                    delivery_work_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    delivery_product_id = table.Column<long>(nullable: false),
                    isCancelled = table.Column<bool>(nullable: false),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true),
                    product_code = table.Column<string>(nullable: true),
                    quantity_number = table.Column<int>(nullable: false),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryProducts", x => x.delivery_work_id);
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
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryWorks", x => x.delivery_work_id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluatedAnswer",
                columns: table => new
                {
                    Tservice_type_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tservice_work_id = table.Column<long>(nullable: false),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    evaluated_answer_id = table.Column<long>(nullable: false),
                    evaluated_question_choice_id = table.Column<long>(nullable: false),
                    evaluated_question_id = table.Column<long>(nullable: false),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluatedAnswer", x => x.Tservice_type_id);
                });

            migrationBuilder.CreateTable(
                name: "ListEvaluatedQuestionChoices",
                columns: table => new
                {
                    evaluated_questtion_choice_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    version_number = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListEvaluatedQuestionChoices", x => x.evaluated_questtion_choice_id);
                });

            migrationBuilder.CreateTable(
                name: "ListEvaluatedQuestions",
                columns: table => new
                {
                    evaluated_question_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tservice_type_id = table.Column<long>(nullable: false),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    hasChoice = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    version_number = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListEvaluatedQuestions", x => x.evaluated_question_id);
                });

            migrationBuilder.CreateTable(
                name: "ListSetupAccessoryProducts",
                columns: table => new
                {
                    list_setup_product_accessory_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isHidden = table.Column<bool>(nullable: false),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true),
                    quantity_available = table.Column<int>(nullable: false),
                    remark = table.Column<string>(nullable: true),
                    setup_product_price = table.Column<double>(nullable: false),
                    setup_product_surplus_price = table.Column<double>(nullable: false),
                    setup_product_surplus_unit_name = table.Column<string>(nullable: true),
                    setup_product_unit_name = table.Column<string>(nullable: true),
                    setup_work_product_type_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListSetupAccessoryProducts", x => x.list_setup_product_accessory_id);
                });

            migrationBuilder.CreateTable(
                name: "ListSetupMainProducts",
                columns: table => new
                {
                    setup_product_main_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<double>(nullable: false),
                    isHidden = table.Column<bool>(nullable: false),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true),
                    remark = table.Column<string>(nullable: true),
                    setup_equipment_price = table.Column<double>(nullable: false),
                    setup_non_equipment_price = table.Column<double>(nullable: false),
                    setup_work_product_type_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListSetupMainProducts", x => x.setup_product_main_id);
                });

            migrationBuilder.CreateTable(
                name: "ListTserviceTypes",
                columns: table => new
                {
                    Tservice_type_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListTserviceTypes", x => x.Tservice_type_id);
                });

            migrationBuilder.CreateTable(
                name: "ListTserviceWorkStatus",
                columns: table => new
                {
                    list_Tservice_work_status_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListTserviceWorkStatus", x => x.list_Tservice_work_status_id);
                });

            migrationBuilder.CreateTable(
                name: "MemberBookAddresses",
                columns: table => new
                {
                    member_book_address_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address_details = table.Column<string>(nullable: true),
                    amphur_id = table.Column<int>(nullable: false),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    district_id = table.Column<int>(nullable: false),
                    map_google_url = table.Column<string>(nullable: true),
                    map_image_url = table.Column<string>(nullable: true),
                    member_email = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    place_name = table.Column<string>(nullable: true),
                    province_id = table.Column<int>(nullable: false),
                    receiver_name = table.Column<string>(nullable: true),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    zip_code = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberBookAddresses", x => x.member_book_address_id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    member_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    birthday_date = table.Column<DateTime>(nullable: false),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    email = table.Column<string>(nullable: true),
                    full_name = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    identity_card_number = table.Column<string>(nullable: true),
                    is_admin = table.Column<bool>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.member_id);
                });

            migrationBuilder.CreateTable(
                name: "SetupAccessoryProducts",
                columns: table => new
                {
                    setup_product_accessory_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    isCancelled = table.Column<bool>(nullable: false),
                    list_setup_product_accessory_id = table.Column<long>(nullable: false),
                    product_accessory_price = table.Column<double>(nullable: false),
                    product_accessory_quantity = table.Column<double>(nullable: false),
                    product_accessory_surplus_price = table.Column<string>(nullable: true),
                    product_accessory_surplus_quantity = table.Column<string>(nullable: true),
                    setup_product_id = table.Column<long>(nullable: false),
                    setup_work_id = table.Column<long>(nullable: false),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupAccessoryProducts", x => x.setup_product_accessory_id);
                });

            migrationBuilder.CreateTable(
                name: "SetupProducts",
                columns: table => new
                {
                    setup_product_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    isCancelled = table.Column<bool>(nullable: false),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true),
                    product_accessory_total_price = table.Column<double>(nullable: false),
                    product_code = table.Column<string>(nullable: true),
                    product_main_total_price = table.Column<double>(nullable: false),
                    quantity_number = table.Column<int>(nullable: false),
                    setup_product_main_id = table.Column<long>(nullable: false),
                    setup_product_type_id = table.Column<long>(nullable: false),
                    setup_work_id = table.Column<long>(nullable: false),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupProducts", x => x.setup_product_id);
                });

            migrationBuilder.CreateTable(
                name: "SetupWorkProductTypes",
                columns: table => new
                {
                    setup_work_product_type_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: true),
                    nameEN = table.Column<string>(nullable: true),
                    nameTH = table.Column<string>(nullable: true),
                    remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupWorkProductTypes", x => x.setup_work_product_type_id);
                });

            migrationBuilder.CreateTable(
                name: "SetupWorks",
                columns: table => new
                {
                    Tservice_work_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tservice_type_id = table.Column<long>(nullable: false),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    isCancelled = table.Column<bool>(nullable: false),
                    member_email = table.Column<string>(nullable: true),
                    receipt_number = table.Column<string>(nullable: true),
                    remark_employee = table.Column<string>(nullable: true),
                    remark_member = table.Column<string>(nullable: true),
                    setup_appointed_datetime = table.Column<DateTime>(nullable: false),
                    setup_finished_datetime = table.Column<DateTime>(nullable: false),
                    setup_price = table.Column<double>(nullable: false),
                    setup_work_id = table.Column<long>(nullable: false),
                    signature_customer_image_url = table.Column<string>(nullable: true),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetupWorks", x => x.Tservice_work_id);
                });

            migrationBuilder.CreateTable(
                name: "TserviceWorkEmployees",
                columns: table => new
                {
                    Tservice_work_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    employee_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TserviceWorkEmployees", x => x.Tservice_work_id);
                });

            migrationBuilder.CreateTable(
                name: "TserviceWorks",
                columns: table => new
                {
                    Tservice_work_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tservice_type_id = table.Column<long>(nullable: false),
                    created_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    updated_datetime = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TserviceWorks", x => x.Tservice_work_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryProducts");

            migrationBuilder.DropTable(
                name: "DeliveryWorks");

            migrationBuilder.DropTable(
                name: "EvaluatedAnswer");

            migrationBuilder.DropTable(
                name: "ListEvaluatedQuestionChoices");

            migrationBuilder.DropTable(
                name: "ListEvaluatedQuestions");

            migrationBuilder.DropTable(
                name: "ListSetupAccessoryProducts");

            migrationBuilder.DropTable(
                name: "ListSetupMainProducts");

            migrationBuilder.DropTable(
                name: "ListTserviceTypes");

            migrationBuilder.DropTable(
                name: "ListTserviceWorkStatus");

            migrationBuilder.DropTable(
                name: "MemberBookAddresses");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "SetupAccessoryProducts");

            migrationBuilder.DropTable(
                name: "SetupProducts");

            migrationBuilder.DropTable(
                name: "SetupWorkProductTypes");

            migrationBuilder.DropTable(
                name: "SetupWorks");

            migrationBuilder.DropTable(
                name: "TserviceWorkEmployees");

            migrationBuilder.DropTable(
                name: "TserviceWorks");
        }
    }
}
