using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAMP.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingRefId",
                table: "AccReq",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_BookingRefId",
                table: "AccReq",
                column: "BookingRefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AccReq_BookingRefId",
                table: "AccReq");

            migrationBuilder.DropColumn(
                name: "BookingRefId",
                table: "AccReq");
        }
    }
}
