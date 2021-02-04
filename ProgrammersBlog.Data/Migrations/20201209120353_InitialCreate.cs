using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1300)", maxLength: 1300, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateByName", "CreateDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4862), "C# Programlama Dili ile ilgili en güncel bilgiler", true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4882), "C#", "C# Blog Kategorisi" },
                    { 2, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4941), "Java Programlama Dili ile ilgili en güncel bilgiler", true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4945), "Java", "Java Blog Kategorisi" },
                    { 3, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4949), "JavaScript Programlama Dili ile ilgili en güncel bilgiler", true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4949), "JavaScript", "JavaScript Blog Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateByName", "CreateDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 204, DateTimeKind.Local).AddTicks(4987), "Admin rolü, tüm haklara sahiptir.", true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 204, DateTimeKind.Local).AddTicks(4991), "Admin", "Admin Rolüdür." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateByName", "CreateDate", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "UserName" },
                values: new object[] { 1, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 211, DateTimeKind.Local).AddTicks(9539), "İlk admin kullanıcı", "dmrdicle@gmail.com", "Dicle", true, false, "Demir", "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 211, DateTimeKind.Local).AddTicks(9543), "Admin Kullanıcısı", new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 }, " https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU", 1, "dicle.demir" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreateByName", "CreateDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[] { 1, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque dictum ultricies dui. Sed semper, est quis molestie venenatis, orci ligula iaculis augue, vel fermentum nunc turpis sed purus. Donec et fermentum leo. Fusce id ligula nibh. Curabitur iaculis est bibendum erat feugiat, eget pharetra urna aliquet. Vivamus vel lectus nec erat rhoncus euismod mattis ut elit. Nulla neque tortor, laoreet non enim vitae, commodo consequat dui. Vestibulum vestibulum convallis fermentum. Vestibulum id molestie quam. Donec vitae luctus justo. Maecenas mattis erat ut tortor euismod sollicitudin. Nunc in lorem ligula. Pellentesque lacinia enim vel magna pulvinar venenatis. Morbi posuere posuere facilisis.\r\n\r\n                Suspendisse vel convallis sem,\r\n                nec tristique felis.Cras aliquam placerat augue,\r\n                quis fringilla lectus.Duis sodales augue sit amet ligula sagittis ultrices.Aenean dignissim lobortis rutrum.Aenean tortor urna,\r\n                volutpat at euismod vitae,\r\n                egestas at odio.Vivamus molestie nisl posuere gravida faucibus.Vivamus aliquam eu ante ac facilisis.Pellentesque efficitur nunc id metus maximus,\r\n                vitae porttitor nunc fringilla.Interdum et malesuada fames ac ante ipsum primis in faucibus.Sed mollis lorem quam,\r\n                et ornare ligula sollicitudin nec.Donec ut lobortis quam.Suspendisse potenti.Phasellus molestie id dolor in pretium.Nam augue libero,\r\n                ullamcorper et nisi a,\r\n                sollicitudin luctus nisi.", "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(533), new DateTime(2020, 12, 9, 15, 3, 53, 194, DateTimeKind.Local).AddTicks(8565), true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(1516), "C# 9.0 ve .Net 5 Yenilikleri", "Dicle Demir", "C# 9.0 ve .Net 5 Yenilikleri", "C#, C# 9, .Net5, .Net Framework, .Net Core", "Default.jpg", "C# 9.0 ve .Net 5 Yenilikleri", 1, 100 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreateByName", "CreateDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[] { 2, 2, 1, "Ut sit amet blandit nisi. Donec dictum lacinia massa, nec mattis sapien luctus et.\r\nPellentesque faucibus nec magna tristique lobortis. Nunc vitae dolor ut dui sollicitudin hendrerit. Nullam imperdiet \r\nluctus orci id mattis. Pellentesque convallis in lectus efficitur tristique. Donec viverra malesuada orci id feugiat. Cras molestie suscipit interdum.\r\n\r\nNunc ante urna, faucibus aliquet finibus sed, congue a lorem. Morbi vel mattis dolor. Fusce vel tortor semper ligula facilisis mattis sit amet sed elit. Quisque viverra sagittis purus vel bibendum. Phasellus aliquam mattis gravida. Maecenas mi sem, ultrices quis nisl vitae, sollicitudin ornare odio. Duis bibendum elit vel sem pharetra, a aliquam nibh fringilla. Vivamus et orci placerat, aliquet quam quis, porttitor est. Morbi vitae justo eget nisl viverra euismod. Duis tempus turpis iaculis justo vestibulum, non efficitur tortor auctor. Nam odio quam, varius eu vehicula sit amet, porttitor vel orci.", "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3954), new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3946), true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3954), "Java 9.0 ve java 5 Yenilikleri", "Dicle Demir", "java 9.0 ve java 5 Yenilikleri", "C#, C# 9, .Net5, .Net Framework, .Net Core", "Default.jpg", "C#, C# 9, .Net5, .Net Framework, .Net Core", 1, 18 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreateByName", "CreateDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[] { 3, 3, 1, "Nam at lorem commodo, auctor felis non, faucibus neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel tellus non neque congue venenatis. Sed augue mauris, lobortis nec posuere ac, vehicula sed sapien. Phasellus ac justo nec lectus sodales rhoncus eget at magna. Sed iaculis mauris et varius iaculis. Sed consequat consectetur nunc et elementum. Nullam lobortis ipsum ut pellentesque vestibulum. Vestibulum volutpat libero sollicitudin posuere fermentum. Sed sed ligula dolor. Proin ullamcorper, lectus a eleifend aliquet, massa nulla porta risus, quis aliquam quam ipsum ac lacus. ", "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3993), new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3993), true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3993), "Java 9.0 ve java 5 Yenilikleri", "Dicle Demir", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "Default.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 280 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreateByName", "CreateDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 1, 1, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1793), true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1797), "C# makale yorumu", "Nunc ante urna, faucibus aliquet finibus sed, congue a lorem." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreateByName", "CreateDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 2, 2, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1829), true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1833), "Java makale yorumu", "Morbi vel mattis dolor. Fusce vel tortor semper ligula." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreateByName", "CreateDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 3, 3, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1833), true, false, "InitialCreate", new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1837), "JavaScript makale yorumu", "Morbi vel mattis dolor. Fusce vel tortor semper ligula." });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
