﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyEfCore.CodeFirst.Migrations
{
    public partial class AddBarcodeFroProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Products");
        }
    }
}
