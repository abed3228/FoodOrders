using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FoodOrders.Data.Migrations
{
    public partial class branch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityBranch = table.Column<string>(nullable: false),
                    NameBranch = table.Column<string>(nullable: false),
                    OpeningHoursBranch = table.Column<string>(nullable: false),
                    PhoneNumberBranch = table.Column<int>(nullable: false),
                    StreetBranch = table.Column<string>(nullable: false),
                    StreetNumberBranch = table.Column<string>(nullable: false),
                    nLatitude = table.Column<double>(nullable: false),
                    nLongitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branch");
        }
    }
}
