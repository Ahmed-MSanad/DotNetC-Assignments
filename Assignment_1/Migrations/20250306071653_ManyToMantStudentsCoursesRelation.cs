using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMantStudentsCoursesRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_StudentTable_Stud_Id",
                table: "Stud_Courses",
                column: "Stud_Id",
                principalTable: "StudentTable",
                principalColumn: "StuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_StudentTable_Stud_Id",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_courses_Course_Id",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Course_Id",
                table: "Stud_Courses");
        }
    }
}
