//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace EFCore.Migrations
//{
//    /// <inheritdoc />
//    public partial class AddAddedOnOnBlogTable : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.RenameTable(
//                name: "Employees",
//                newName: "Employees",
//                newSchema: "blogging");

//            migrationBuilder.RenameTable(
//                name: "Blogs",
//                newName: "Blogs",
//                newSchema: "blogging");

//            migrationBuilder.RenameTable(
//                name: "AuditEntry",
//                newName: "AuditEntry",
//                newSchema: "blogging");
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.RenameTable(
//                name: "Employees",
//                schema: "blogging",
//                newName: "Employees");

//            migrationBuilder.RenameTable(
//                name: "Blogs",
//                schema: "blogging",
//                newName: "Blogs");

//            migrationBuilder.RenameTable(
//                name: "AuditEntry",
//                schema: "blogging",
//                newName: "AuditEntry");
//        }
//    }
//}