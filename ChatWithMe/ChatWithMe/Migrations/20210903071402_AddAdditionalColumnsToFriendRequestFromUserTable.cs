namespace ChatWithMe.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddAdditionalColumnsToFriendRequestFromUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendRequestsFromUsers_AspNetUsers_ApplicationUserId",
                table: "FriendRequestsFromUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_friendRequestsToUsers_AspNetUsers_ApplicationUserId",
                table: "friendRequestsToUsers");

            migrationBuilder.DropColumn(
                name: "ApllicationUserId",
                table: "friendRequestsToUsers");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "friendRequestsToUsers",
                newName: "ToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_friendRequestsToUsers_ApplicationUserId",
                table: "friendRequestsToUsers",
                newName: "IX_friendRequestsToUsers_ToUserId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "FriendRequestsFromUsers",
                newName: "FromUserId");

            migrationBuilder.RenameColumn(
                name: "ApllicationUserId",
                table: "FriendRequestsFromUsers",
                newName: "LastName");

            migrationBuilder.RenameIndex(
                name: "IX_FriendRequestsFromUsers_ApplicationUserId",
                table: "FriendRequestsFromUsers",
                newName: "IX_FriendRequestsFromUsers_FromUserId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "FriendRequestsFromUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRequestsFromUsers_AspNetUsers_FromUserId",
                table: "FriendRequestsFromUsers",
                column: "FromUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_friendRequestsToUsers_AspNetUsers_ToUserId",
                table: "friendRequestsToUsers",
                column: "ToUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendRequestsFromUsers_AspNetUsers_FromUserId",
                table: "FriendRequestsFromUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_friendRequestsToUsers_AspNetUsers_ToUserId",
                table: "friendRequestsToUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "FriendRequestsFromUsers");

            migrationBuilder.RenameColumn(
                name: "ToUserId",
                table: "friendRequestsToUsers",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_friendRequestsToUsers_ToUserId",
                table: "friendRequestsToUsers",
                newName: "IX_friendRequestsToUsers_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "FriendRequestsFromUsers",
                newName: "ApllicationUserId");

            migrationBuilder.RenameColumn(
                name: "FromUserId",
                table: "FriendRequestsFromUsers",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_FriendRequestsFromUsers_FromUserId",
                table: "FriendRequestsFromUsers",
                newName: "IX_FriendRequestsFromUsers_ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "ApllicationUserId",
                table: "friendRequestsToUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRequestsFromUsers_AspNetUsers_ApplicationUserId",
                table: "FriendRequestsFromUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_friendRequestsToUsers_AspNetUsers_ApplicationUserId",
                table: "friendRequestsToUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
