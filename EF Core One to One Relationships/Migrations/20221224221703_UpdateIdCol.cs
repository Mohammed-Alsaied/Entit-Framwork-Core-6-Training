using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreRelationships.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BLogImage_Blogs_BlogId",
                table: "BLogImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BLogImage",
                table: "BLogImage");

            migrationBuilder.RenameTable(
                name: "BLogImage",
                newName: "BlogImages");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Blogs",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_BLogImage_BlogId",
                table: "BlogImages",
                newName: "IX_BlogImages_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogImages",
                table: "BlogImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogImages_Blogs_BlogId",
                table: "BlogImages",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogImages_Blogs_BlogId",
                table: "BlogImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogImages",
                table: "BlogImages");

            migrationBuilder.RenameTable(
                name: "BlogImages",
                newName: "BLogImage");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Blogs",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_BlogImages_BlogId",
                table: "BLogImage",
                newName: "IX_BLogImage_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BLogImage",
                table: "BLogImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BLogImage_Blogs_BlogId",
                table: "BLogImage",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
