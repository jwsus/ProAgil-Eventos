﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProaAgil.API.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Place = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Theme = table.Column<string>(nullable: true),
                    amountPerson = table.Column<int>(nullable: false),
                    Lot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
