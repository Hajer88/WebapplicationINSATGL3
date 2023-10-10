using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebapplicationINSATGL3.Migrations
{
    public partial class TestMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
         INSERT INTO Movies (Name) VALUES('test')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
