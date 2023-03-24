using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class miggüncel2addabout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Abouts",
               columns: table => new
               {
                   AboutID = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   AboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   AboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   AboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   AboutImage2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   AboutMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   AboutStatus = table.Column<bool>(type: "bit", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Abouts", x => x.AboutID);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
