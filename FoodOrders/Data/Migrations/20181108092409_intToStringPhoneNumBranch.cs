using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FoodOrders.Data.Migrations
{
    public partial class intToStringPhoneNumBranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumberBranch",
                table: "Branch",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumberBranch",
                table: "Branch",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
