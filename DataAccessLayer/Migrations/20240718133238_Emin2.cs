﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Emin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategories_CategoryId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Courses",
                newName: "CourseCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                newName: "IX_Courses_CourseCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategories_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId",
                principalTable: "CourseCategories",
                principalColumn: "CourseCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategories_CourseCategoryId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "CourseCategoryId",
                table: "Courses",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_CourseCategoryId",
                table: "Courses",
                newName: "IX_Courses_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "CourseCategories",
                principalColumn: "CourseCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
