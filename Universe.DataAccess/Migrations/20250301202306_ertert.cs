using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ertert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserFollower",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFollower_User_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserFollower_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFollower_FollowerId",
                table: "UserFollower",
                column: "FollowerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollower_UserId",
                table: "UserFollower",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFollower");
        }
    }
}
