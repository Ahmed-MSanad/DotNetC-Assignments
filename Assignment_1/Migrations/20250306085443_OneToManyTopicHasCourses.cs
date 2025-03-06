using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyTopicHasCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_courses_Top_Id",
                table: "courses",
                column: "Top_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_topics_Top_Id",
                table: "courses",
                column: "Top_Id",
                principalTable: "topics",
                principalColumn: "TopId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_topics_Top_Id",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_Top_Id",
                table: "courses");
        }
    }
}
