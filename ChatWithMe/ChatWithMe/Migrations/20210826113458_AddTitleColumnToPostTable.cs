namespace ChatWithMe.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddTitleColumnToPostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TextTitle",
                table: "Posts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextTitle",
                table: "Posts");
        }
    }
}
