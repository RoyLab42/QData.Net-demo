﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoyLab.QData.Demo.Migrations
{
    public partial class InitUserDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserModel");
        }
    }
}
