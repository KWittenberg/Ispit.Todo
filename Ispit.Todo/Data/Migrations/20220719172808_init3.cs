using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ispit.Todo.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_AspNetUsers_ApplicationUserId",
                table: "Todo");

            migrationBuilder.DropIndex(
                name: "IX_Todo_ApplicationUserId",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Todo");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b5b0da-e61e-46ba-b766-e1acc7401352",
                column: "ConcurrencyStamp",
                value: "9e6e08cb-addb-4ead-96c7-25f514bca150");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "badd4ddd-df0e-4621-af37-c2b36aaa6742",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4856baed-381a-4e56-b63f-c5b138ef62d8", "AQAAAAEAACcQAAAAEBv1ghtMmu91dr9pHIPlgJ7HM5ZtFHT253rUHzY6C5spoSRWmXdBRG2b0u/RX5xkig==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Todo",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b5b0da-e61e-46ba-b766-e1acc7401352",
                column: "ConcurrencyStamp",
                value: "4403a2b6-6bb5-44c2-8f7f-54d293ff5d5f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "badd4ddd-df0e-4621-af37-c2b36aaa6742",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "104dcbaf-94fc-4b30-95d1-d9e34c5acba3", "AQAAAAEAACcQAAAAEJl+NG5Gh8dVMaj3XTpgjxoVg4ct4aQw7iRs6lH8B0RAfoEcENz4RdOI3/9Kf6jNFg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Todo_ApplicationUserId",
                table: "Todo",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_AspNetUsers_ApplicationUserId",
                table: "Todo",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
