using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectOne.Migrations
{
    public partial class remove_vender_detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vendorDetails");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "vendors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "vendors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "vendors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "vendors",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "vendors");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "vendors");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "vendors");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "vendors");

            migrationBuilder.CreateTable(
                name: "vendorDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendorDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vendorDetails_vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vendorDetails_VendorId",
                table: "vendorDetails",
                column: "VendorId");
        }
    }
}
