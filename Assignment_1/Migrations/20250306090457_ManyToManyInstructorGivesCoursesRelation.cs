using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyInstructorGivesCoursesRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Course_Ins_Course_Id",
                table: "Course_Ins",
                column: "Course_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Ins_InstructorTable_Ins_Id",
                table: "Course_Ins",
                column: "Ins_Id",
                principalSchema: "Teaching",
                principalTable: "InstructorTable",
                principalColumn: "insId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Ins_courses_Course_Id",
                table: "Course_Ins",
                column: "Course_Id",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Ins_InstructorTable_Ins_Id",
                table: "Course_Ins");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Ins_courses_Course_Id",
                table: "Course_Ins");

            migrationBuilder.DropIndex(
                name: "IX_Course_Ins_Course_Id",
                table: "Course_Ins");
        }
    }
}
