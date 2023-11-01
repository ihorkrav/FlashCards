using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashCards.Migrations
{
    public partial class card_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Decks_DeckId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_DeckId",
                table: "Cards");

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Decks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "DeckId",
                table: "Cards",
                newName: "DeckID");

            migrationBuilder.RenameColumn(
                name: "FronData",
                table: "Cards",
                newName: "FrontData");

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "BackData", "BackImg", "DeckID", "FrontData", "FrontImg", "Priority" },
                values: new object[,]
                {
                    { 1, "4", null, 1, "2+2 = ?", null, 1 },
                    { 2, "4", null, 1, "2*2 = ?", null, 1 },
                    { 3, "4", null, 1, "2^2 = ?", null, 1 },
                    { 4, "16", null, 1, "4*4 = ?", null, 1 },
                    { 5, "9", null, 1, "3^2 = ?", null, 1 },
                    { 6, "17", null, 1, "9+8 = ?", null, 1 },
                    { 7, "33", null, 1, "22+11 = ?", null, 1 },
                    { 8, "81", null, 1, "33+48 = ?", null, 1 },
                    { 9, "60", null, 1, "55+5 = ?", null, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.RenameColumn(
                name: "DeckID",
                table: "Cards",
                newName: "DeckId");

            migrationBuilder.RenameColumn(
                name: "FrontData",
                table: "Cards",
                newName: "FronData");

            migrationBuilder.InsertData(
                table: "Decks",
                columns: new[] { "Id", "AmountOfCards", "Title" },
                values: new object[,]
                {
                    { 1, 340, "New card" },
                    { 2, 350, "New card1" },
                    { 3, 60, "New card2" },
                    { 4, 8, "New card3" },
                    { 5, 10, "New card4" },
                    { 6, 70, "New card5" },
                    { 7, 70, "New card6" },
                    { 8, 15, "New card7" },
                    { 9, 20, "New card8" },
                    { 10, 12, "New card9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DeckId",
                table: "Cards",
                column: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Decks_DeckId",
                table: "Cards",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
