using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class fixedRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_InfoUsers_RoomId",
                table: "Restaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_InfoUsers_RoomId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "InfoUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomId",
                table: "Rooms",
                newName: "IX_Rooms_InfoUserId");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Restaurants",
                newName: "InfoUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Restaurants_RoomId",
                table: "Restaurants",
                newName: "IX_Restaurants_InfoUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_InfoUsers_InfoUserId",
                table: "Restaurants",
                column: "InfoUserId",
                principalTable: "InfoUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_InfoUsers_InfoUserId",
                table: "Rooms",
                column: "InfoUserId",
                principalTable: "InfoUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_InfoUsers_InfoUserId",
                table: "Restaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_InfoUsers_InfoUserId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "InfoUserId",
                table: "Rooms",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_InfoUserId",
                table: "Rooms",
                newName: "IX_Rooms_RoomId");

            migrationBuilder.RenameColumn(
                name: "InfoUserId",
                table: "Restaurants",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Restaurants_InfoUserId",
                table: "Restaurants",
                newName: "IX_Restaurants_RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_InfoUsers_RoomId",
                table: "Restaurants",
                column: "RoomId",
                principalTable: "InfoUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_InfoUsers_RoomId",
                table: "Rooms",
                column: "RoomId",
                principalTable: "InfoUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
