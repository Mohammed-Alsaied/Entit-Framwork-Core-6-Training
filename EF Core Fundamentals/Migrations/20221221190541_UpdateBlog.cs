//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace EFCore.Migrations
//{
//    /// <inheritdoc />
//    public partial class UpdateBlog : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Posts_Blogs_BlogID",
//                schema: "blogging",
//                table: "Posts");

//            migrationBuilder.DropPrimaryKey(
//                name: "PK_Posts",
//                schema: "blogging",
//                table: "Posts");

//            migrationBuilder.RenameTable(
//                name: "Posts",
//                schema: "blogging",
//                newName: "Post");

//            migrationBuilder.RenameIndex(
//                name: "IX_Posts_BlogID",
//                table: "Post",
//                newName: "IX_Post_BlogID");

//            migrationBuilder.AlterColumn<string>(
//                name: "Url",
//                table: "Blogs",
//                type: "varchar(200)",
//                nullable: false,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)");

//            migrationBuilder.AddColumn<decimal>(
//                name: "Rating",
//                table: "Blogs",
//                type: "decimal(5,2)",
//                nullable: false,
//                defaultValue: 0m);

//            migrationBuilder.AddPrimaryKey(
//                name: "PK_Post",
//                table: "Post",
//                column: "Id");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Post_Blogs_BlogID",
//                table: "Post",
//                column: "BlogID",
//                principalTable: "Blogs",
//                principalColumn: "ID",
//                onDelete: ReferentialAction.Cascade);
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Post_Blogs_BlogID",
//                table: "Post");

//            migrationBuilder.DropPrimaryKey(
//                name: "PK_Post",
//                table: "Post");

//            migrationBuilder.DropColumn(
//                name: "Rating",
//                table: "Blogs");

//            migrationBuilder.EnsureSchema(
//                name: "blogging");

//            migrationBuilder.RenameTable(
//                name: "Post",
//                newName: "Posts",
//                newSchema: "blogging");

//            migrationBuilder.RenameIndex(
//                name: "IX_Post_BlogID",
//                schema: "blogging",
//                table: "Posts",
//                newName: "IX_Posts_BlogID");

//            migrationBuilder.AlterColumn<string>(
//                name: "Url",
//                table: "Blogs",
//                type: "nvarchar(max)",
//                nullable: false,
//                oldClrType: typeof(string),
//                oldType: "varchar(200)");

//            migrationBuilder.AddPrimaryKey(
//                name: "PK_Posts",
//                schema: "blogging",
//                table: "Posts",
//                column: "Id");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Posts_Blogs_BlogID",
//                schema: "blogging",
//                table: "Posts",
//                column: "BlogID",
//                principalTable: "Blogs",
//                principalColumn: "ID",
//                onDelete: ReferentialAction.Cascade);
//        }
//    }
//}