namespace ChatWithMe.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddCustomProfilePictureToUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomPofilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomPofilePicture",
                table: "AspNetUsers");
        }
    }
}
