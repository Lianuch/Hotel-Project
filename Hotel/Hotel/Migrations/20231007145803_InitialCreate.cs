using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfoUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "appUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Pace = table.Column<int>(type: "int", nullable: true),
                    Mileage = table.Column<int>(type: "int", nullable: true),
                    InfoUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_appUser_InfoUsers_InfoUserId",
                        column: x => x.InfoUserId,
                        principalTable: "InfoUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    RestaurantCategory = table.Column<int>(type: "int", nullable: false),
                    appUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_InfoUsers_RoomId",
                        column: x => x.RoomId,
                        principalTable: "InfoUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurants_appUser_appUserId",
                        column: x => x.appUserId,
                        principalTable: "appUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    RoomCategory = table.Column<int>(type: "int", nullable: false),
                    appUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_InfoUsers_RoomId",
                        column: x => x.RoomId,
                        principalTable: "InfoUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_appUser_appUserId",
                        column: x => x.appUserId,
                        principalTable: "appUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_appUser_InfoUserId",
                table: "appUser",
                column: "InfoUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_appUserId",
                table: "Restaurants",
                column: "appUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RoomId",
                table: "Restaurants",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_appUserId",
                table: "Rooms",
                column: "appUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomId",
                table: "Rooms",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "appUser");

            migrationBuilder.DropTable(
                name: "InfoUsers");
        }
    }
}
