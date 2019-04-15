using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('honda')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('toyota')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('mazda')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('civic',1)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('accord',1)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('corolla',2)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('camry',2)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('model3',3)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('model6',3)");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes where name in ('honda','toyota','mazda')");
        }
    }
}
