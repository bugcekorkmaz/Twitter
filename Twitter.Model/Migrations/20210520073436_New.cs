using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Twitter.Model.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Tweets_TweetID1",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserID",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Tweets_UserID",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Likes_TweetID1",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "TweetID1",
                table: "Likes");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Tweets",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserID1",
                table: "Tweets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Retweets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TweetID",
                table: "Retweets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Medias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Likes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "TweetID",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Followings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Followers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TweetID",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_UserID1",
                table: "Tweets",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_TweetID",
                table: "Likes",
                column: "TweetID");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Tweets_TweetID",
                table: "Likes",
                column: "TweetID",
                principalTable: "Tweets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Likes_Tweets_TweetID",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserID1",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Tweets_UserID1",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Likes_TweetID",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Tweets");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "Tweets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Retweets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TweetID",
                table: "Retweets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Medias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TweetID",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TweetID1",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Followings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Followers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TweetID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_UserID",
                table: "Tweets",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_TweetID1",
                table: "Likes",
                column: "TweetID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Tweets_TweetID1",
                table: "Likes",
                column: "TweetID1",
                principalTable: "Tweets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

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
