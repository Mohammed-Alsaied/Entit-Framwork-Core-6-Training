//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace EFCore.Migrations
//{
//    /// <inheritdoc />
//    public partial class AddBooksTable : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Post_Blogs_BlogID",
//                table: "Post");

//            migrationBuilder.AlterColumn<string>(
//                name: "Title",
//                table: "Post",
//                type: "nvarchar(max)",
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)");

//            migrationBuilder.AlterColumn<string>(
//                name: "Content",
//                table: "Post",
//                type: "nvarchar(max)",
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)");

//            migrationBuilder.AlterColumn<int>(
//                name: "BlogID",
//                table: "Post",
//                type: "int",
//                nullable: true,
//                oldClrType: typeof(int),
//                oldType: "int");

//            migrationBuilder.AlterColumn<string>(
//                name: "Url",
//                table: "Blogs",
//                type: "nvarchar(200)",
//                maxLength: 200,
//                nullable: false,
//                comment: "test comment",
//                oldClrType: typeof(string),
//                oldType: "varchar(200)");

//            migrationBuilder.AlterColumn<int>(
//                name: "Rating",
//                table: "Blogs",
//                type: "int",
//                nullable: false,
//                defaultValue: 2,
//                oldClrType: typeof(decimal),
//                oldType: "decimal(5,2)");

//            migrationBuilder.AlterColumn<string>(
//                name: "Username",
//                table: "AuditEntry",
//                type: "nvarchar(max)",
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)");

//            migrationBuilder.AlterColumn<string>(
//                name: "Action",
//                table: "AuditEntry",
//                type: "nvarchar(max)",
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)");

//            migrationBuilder.CreateTable(
//                name: "Books",
//                columns: table => new
//                {
//                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    Author = table.Column<string>(type: "nvarchar(450)", nullable: false),
//                    BookKey = table.Column<int>(type: "int", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Books", x => new { x.Name, x.Author });
//                });

//            migrationBuilder.AddForeignKey(
//                name: "FK_Post_Blogs_BlogID",
//                table: "Post",
//                column: "BlogID",
//                principalTable: "Blogs",
//                principalColumn: "ID");
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Post_Blogs_BlogID",
//                table: "Post");

//            migrationBuilder.DropTable(
//                name: "Books");

//            migrationBuilder.AlterColumn<string>(
//                name: "Title",
//                table: "Post",
//                type: "nvarchar(max)",
//                nullable: false,
//                defaultValue: "",
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)",
//                oldNullable: true);

//            migrationBuilder.AlterColumn<string>(
//                name: "Content",
//                table: "Post",
//                type: "nvarchar(max)",
//                nullable: false,
//                defaultValue: "",
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)",
//                oldNullable: true);

//            migrationBuilder.AlterColumn<int>(
//                name: "BlogID",
//                table: "Post",
//                type: "int",
//                nullable: false,
//                defaultValue: 0,
//                oldClrType: typeof(int),
//                oldType: "int",
//                oldNullable: true);

//            migrationBuilder.AlterColumn<string>(
//                name: "Url",
//                table: "Blogs",
//                type: "varchar(200)",
//                nullable: false,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(200)",
//                oldMaxLength: 200,
//                oldComment: "test comment");

//            migrationBuilder.AlterColumn<decimal>(
//                name: "Rating",
//                table: "Blogs",
//                type: "decimal(5,2)",
//                nullable: false,
//                oldClrType: typeof(int),
//                oldType: "int",
//                oldDefaultValue: 2);

//            migrationBuilder.AlterColumn<string>(
//                name: "Username",
//                table: "AuditEntry",
//                type: "nvarchar(max)",
//                nullable: false,
//                defaultValue: "",
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)",
//                oldNullable: true);

//            migrationBuilder.AlterColumn<string>(
//                name: "Action",
//                table: "AuditEntry",
//                type: "nvarchar(max)",
//                nullable: false,
//                defaultValue: "",
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)",
//                oldNullable: true);

//            migrationBuilder.AddForeignKey(
//                name: "FK_Post_Blogs_BlogID",
//                table: "Post",
//                column: "BlogID",
//                principalTable: "Blogs",
//                principalColumn: "ID",
//                onDelete: ReferentialAction.Cascade);
//        }
//    }
//}