using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyDepartmentInstructorRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_InstructorTable_Dep_Id",
                schema: "Teaching",
                table: "InstructorTable",
                column: "Dep_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTable_departments_Dep_Id",
                schema: "Teaching",
                table: "InstructorTable",
                column: "Dep_Id",
                principalTable: "departments",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTable_departments_Dep_Id",
                schema: "Teaching",
                table: "InstructorTable");

            migrationBuilder.DropIndex(
                name: "IX_InstructorTable_Dep_Id",
                schema: "Teaching",
                table: "InstructorTable");
        }
    }
}
