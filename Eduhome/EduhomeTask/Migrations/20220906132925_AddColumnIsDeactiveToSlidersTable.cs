﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EduhomeTask.Migrations
{
    public partial class AddColumnIsDeactiveToSlidersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeactive",
                table: "Sliders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeactive",
                table: "Sliders");
        }
    }
}
