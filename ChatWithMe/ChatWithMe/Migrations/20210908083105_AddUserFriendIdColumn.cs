using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatWithMe.Migrations
{
    public partial class AddUserFriendIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserFriendId",
                table: "Friends",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserFriendId",
                table: "Friends",
                column: "UserFriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_UserFriendId",
                table: "Friends",
                column: "UserFriendId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_UserFriendId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserFriendId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserFriendId",
                table: "Friends");
        }
    }
}
