using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ispit.Todo.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b5b0da-e61e-46ba-b766-e1acc7401352",
                column: "ConcurrencyStamp",
                value: "55ea21cc-13f2-4ca7-b1ba-c832bbf4f166");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "badd4ddd-df0e-4621-af37-c2b36aaa6742",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b166e36-c7e6-4ab1-8ab5-141bbfbf7ae4", "AQAAAAEAACcQAAAAECBDzcR+2vDr+DdrzPAQ78w66jOr1LZjFzRpQVsFvsTDLJVQ6RAs6AZEL8Eh8poMRA==" });
        }
    }
}
