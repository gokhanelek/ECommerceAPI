using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceAPI.Persistence.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Products",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Orders",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Customers",
                newName: "UpdatedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Products",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Orders",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Customers",
                newName: "UpdateDate");
        }
    }
}
