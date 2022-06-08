using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.DAL.Migrations
{
    public partial class CreateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "FirstName", "LastName", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3721), null, "Michelle", "Alexander", 1, null },
                    { 2, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3734), null, "Stephen E.", "Ambrose", 1, null },
                    { 3, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3734), null, "Margaret", "Atwood", 1, null },
                    { 4, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3734), null, "Jane", "Austen", 1, null },
                    { 5, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3737), null, "James", "Baldwin", 1, null },
                    { 6, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3737), null, "Emily", "Bronte", 1, null },
                    { 7, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3737), null, "Agatha", "Christie", 1, null },
                    { 8, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3741), null, "Ta-Nehisi", "Coates", 1, null },
                    { 9, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3741), null, "Jared", "Diamond", 1, null },
                    { 10, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3741), null, "Joan", "Didion", 1, null },
                    { 11, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3744), null, "Daphne", "Du Maurier", 1, null },
                    { 12, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3744), null, "Tina", "Fey", 1, null },
                    { 13, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3744), null, "Roxane", "Gay", 1, null },
                    { 14, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3747), null, "Dashiel", "Hammett", 1, null },
                    { 15, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3747), null, "Frank", "Herbert", 1, null },
                    { 16, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3747), null, "Aldous", "Huxley", 1, null },
                    { 17, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3751), null, "Stieg", "Larsson", 1, null },
                    { 18, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3751), null, "David", "McCullough", 1, null },
                    { 19, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3754), null, "Toni", "Morrison", 1, null },
                    { 20, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3754), null, "George", "Orwell", 1, null },
                    { 21, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3754), null, "Mary", "Shelley", 1, null },
                    { 22, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3757), null, "Sun", "Tzu", 1, null },
                    { 23, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3757), null, "Augusten", "Burroughs", 1, null },
                    { 25, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3757), null, "JK", "Rowling", 1, null },
                    { 26, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(3760), null, "Seth", "Grahame-Smith", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Name", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { "history", new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4214), null, "History", 1, null },
                    { "memoir", new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4211), null, "Memoir", 1, null },
                    { "mystery", new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4211), null, "Mystery", 1, null },
                    { "novel", new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4207), null, "Novel", 1, null },
                    { "scifi", new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4214), null, "Science Finction", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "GenreId", "Price", "Status", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4088), null, "history", 18.0, 1, "1776", null },
                    { 2, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4092), null, "scifi", 5.5, 1, "1984", null },
                    { 3, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4095), null, "mystery", 4.5, 1, "And Then There Were None", null },
                    { 4, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4095), null, "history", 11.5, 1, "Band of Brothers", null },
                    { 5, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4098), null, "novel", 10.99, 1, "Beloved", null },
                    { 6, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4098), null, "memoir", 13.5, 1, "Between the World and Me", null },
                    { 7, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4098), null, "memoir", 4.25, 1, "Bossypants", null },
                    { 8, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4098), null, "scifi", 16.25, 1, "Brave New World", null },
                    { 9, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4101), null, "history", 15.0, 1, "D-Day", null },
                    { 10, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4101), null, "memoir", 12.5, 1, "Down and Out in Paris and London", null },
                    { 11, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4105), null, "scifi", 8.75, 1, "Dune", null },
                    { 12, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4105), null, "novel", 9.0, 1, "Emma", null },
                    { 13, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4105), null, "scifi", 6.5, 1, "Frankenstein", null },
                    { 14, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4108), null, "novel", 10.25, 1, "Go Tell it on the Mountain", null },
                    { 15, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4108), null, "history", 15.5, 1, "Guns, Germs, and Steel", null },
                    { 16, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4108), null, "memoir", 14.5, 1, "Hunger", null },
                    { 17, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4111), null, "mystery", 6.75, 1, "Murder on the Orient Express", null },
                    { 18, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4111), null, "novel", 8.5, 1, "Pride and Prejudice", null },
                    { 19, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4111), null, "mystery", 10.99, 1, "Rebecca", null },
                    { 20, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4115), null, "history", 5.75, 1, "The Art of War", null },
                    { 21, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4115), null, "mystery", 8.5, 1, "The Girl with the Dragon Tattoo", null },
                    { 22, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4115), null, "scifi", 12.5, 1, "The Handmaid's Tale", null },
                    { 23, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4118), null, "mystery", 10.99, 1, "The Maltese Falcon", null },
                    { 24, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4118), null, "history", 13.75, 1, "The New Jim Crow", null },
                    { 25, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4118), null, "memoir", 13.5, 1, "The Year of Magical Thinking", null },
                    { 26, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4121), null, "novel", 9.0, 1, "Wuthering Heights", null },
                    { 27, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4121), null, "memoir", 11.0, 1, "Running With Scissors", null },
                    { 28, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4121), null, "novel", 8.75, 1, "Pride and Prejudice and Zombies", null },
                    { 29, new DateTime(2022, 6, 2, 11, 47, 22, 662, DateTimeKind.Local).AddTicks(4125), null, "novel", 9.75, 1, "Harry Potter and the Sorcerer's Stone", null }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 18, 1 },
                    { 20, 2 },
                    { 7, 3 },
                    { 2, 4 },
                    { 19, 5 },
                    { 8, 6 },
                    { 12, 7 },
                    { 16, 8 },
                    { 2, 9 },
                    { 20, 10 },
                    { 15, 11 },
                    { 4, 12 },
                    { 21, 13 },
                    { 5, 14 },
                    { 9, 15 },
                    { 13, 16 },
                    { 7, 17 },
                    { 4, 18 },
                    { 11, 19 },
                    { 22, 20 },
                    { 17, 21 },
                    { 3, 22 },
                    { 14, 23 },
                    { 1, 24 },
                    { 10, 25 },
                    { 6, 26 },
                    { 23, 27 },
                    { 4, 28 },
                    { 26, 28 },
                    { 25, 29 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
