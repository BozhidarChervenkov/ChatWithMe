using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatWithMe.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_friendRequestsToUsers_AspNetUsers_ToUserId",
                table: "friendRequestsToUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_friendRequestsToUsers",
                table: "friendRequestsToUsers");

            migrationBuilder.RenameTable(
                name: "friendRequestsToUsers",
                newName: "FriendRequestsToUsers");

            migrationBuilder.RenameIndex(
                name: "IX_friendRequestsToUsers_ToUserId",
                table: "FriendRequestsToUsers",
                newName: "IX_FriendRequestsToUsers_ToUserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FriendRequestsToUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FriendRequestsFromUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_FriendRequestsToUsers",
                table: "FriendRequestsToUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRequestsToUsers_AspNetUsers_ToUserId",
                table: "FriendRequestsToUsers",
                column: "ToUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendRequestsToUsers_AspNetUsers_ToUserId",
                table: "FriendRequestsToUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FriendRequestsToUsers",
                table: "FriendRequestsToUsers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FriendRequestsToUsers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FriendRequestsFromUsers");

            migrationBuilder.RenameTable(
                name: "FriendRequestsToUsers",
                newName: "friendRequestsToUsers");

            migrationBuilder.RenameIndex(
                name: "IX_FriendRequestsToUsers_ToUserId",
                table: "friendRequestsToUsers",
                newName: "IX_friendRequestsToUsers_ToUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_friendRequestsToUsers",
                table: "friendRequestsToUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_friendRequestsToUsers_AspNetUsers_ToUserId",
                table: "friendRequestsToUsers",
                column: "ToUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
