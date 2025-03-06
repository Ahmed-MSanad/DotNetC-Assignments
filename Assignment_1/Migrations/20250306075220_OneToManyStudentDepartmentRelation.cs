using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyStudentDepartmentRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StudentTable_Dep_Id",
                table: "StudentTable",
                column: "Dep_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTable_departments_Dep_Id",
                table: "StudentTable",
                column: "Dep_Id",
                principalTable: "departments",
                principalColumn: "deptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTable_departments_Dep_Id",
                table: "StudentTable");

            migrationBuilder.DropIndex(
                name: "IX_StudentTable_Dep_Id",
                table: "StudentTable");
        }
    }
}
