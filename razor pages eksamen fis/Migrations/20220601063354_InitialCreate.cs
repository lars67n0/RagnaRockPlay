using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace razor_pages_eksamen_fis.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoundList",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoundName = table.Column<string>(nullable: true),
                    RealeaseDate = table.Column<DateTime>(nullable: false),
                    SubTitle = table.Column<string>(nullable: true),
                    SoundInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoundList", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoundList");
        }
    }
}
