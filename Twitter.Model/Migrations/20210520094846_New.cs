using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Twitter.Model.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserID",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Tweets_UserID",
                table: "Tweets");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Tweets",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserID1",
                table: "Tweets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_UserID1",
                table: "Tweets",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweets_Users_UserID1",
                table: "Tweets",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserID1",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Tweets_UserID1",
                table: "Tweets");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Tweets");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "Tweets",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_UserID",
                table: "Tweets",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweets_Users_UserID",
                table: "Tweets",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
