using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyInstructorManageDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Ins_Id",
                table: "departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_departments_Ins_Id",
                table: "departments",
                column: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_InstructorTable_Ins_Id",
                table: "departments",
                column: "Ins_Id",
                principalSchema: "Teaching",
                principalTable: "InstructorTable",
                principalColumn: "insId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_InstructorTable_Ins_Id",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_Ins_Id",
                table: "departments");

            migrationBuilder.AlterColumn<int>(
                name: "Ins_Id",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
