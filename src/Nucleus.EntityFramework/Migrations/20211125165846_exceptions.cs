using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nucleus.EntityFramework.Migrations
{
    public partial class exceptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("068a0171-a141-4eb2-854c-88e43ef9ab7f"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("2a1ccb43-fa4f-48ce-b601-d3ab4d611b32"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 509, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("70b5c5c3-2267-4f7c-b0f9-7ecc952e04a6"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("80562f50-8a7d-4bcd-8971-6d856bbcbb7f"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("86d804bd-d022-49a5-821a-d2240478aac4"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("8f3de3ec-3851-4ba9-887a-2119f18ae744"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("8f76de0b-114a-4df8-a93d-cec927d06a3c"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("d4d7c0e3-efcf-4dd2-86e7-17d69fda8c75"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ea003a99-4755-4c19-b126-c5cffbc65088"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 58, 44, 510, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce"),
                column: "ConcurrencyStamp",
                value: "fa1f72d3-e2b0-4283-8abe-5a0afeabbf7e");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                column: "ConcurrencyStamp",
                value: "c2a89cd7-4f86-4874-8ce7-980643ccfdab");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("065e903e-6f7b-42b8-b807-0c4197f9d1bc"),
                column: "ConcurrencyStamp",
                value: "90c84ff3-4241-45c8-b32a-9dc78451899b");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b6d9e45-626d-489a-a8cf-d32d36583af4"),
                column: "ConcurrencyStamp",
                value: "01ed1d5d-6960-4388-a04f-b8c222ca50c3");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c41a7761-6645-4e2c-b99d-f9e767b9ac77"),
                column: "ConcurrencyStamp",
                value: "57d20b44-b5d5-40d6-bad7-1ab5a186fb01");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("068a0171-a141-4eb2-854c-88e43ef9ab7f"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("28126ffd-51c2-4201-939c-b64e3df43b9d"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("2a1ccb43-fa4f-48ce-b601-d3ab4d611b32"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 531, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("70b5c5c3-2267-4f7c-b0f9-7ecc952e04a6"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("80562f50-8a7d-4bcd-8971-6d856bbcbb7f"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("86d804bd-d022-49a5-821a-d2240478aac4"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("8f3de3ec-3851-4ba9-887a-2119f18ae744"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("8f76de0b-114a-4df8-a93d-cec927d06a3c"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("d4d7c0e3-efcf-4dd2-86e7-17d69fda8c75"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ea003a99-4755-4c19-b126-c5cffbc65088"),
                column: "CreationDate",
                value: new DateTime(2021, 11, 25, 19, 47, 12, 532, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("11d14a89-3a93-4d39-a94f-82b823f0d4ce"),
                column: "ConcurrencyStamp",
                value: "f813d6b2-61a8-4f02-9c48-2677d0d6fa41");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f22bce18-06ec-474a-b9af-a9de2a7b8263"),
                column: "ConcurrencyStamp",
                value: "73c20bf6-abc6-4b11-9c78-c0adba9027e5");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("065e903e-6f7b-42b8-b807-0c4197f9d1bc"),
                column: "ConcurrencyStamp",
                value: "e3e85a3d-46b8-4710-9db5-b7d4d227adfa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b6d9e45-626d-489a-a8cf-d32d36583af4"),
                column: "ConcurrencyStamp",
                value: "d6715778-d0b9-4dd5-b63e-68f3c9840d34");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c41a7761-6645-4e2c-b99d-f9e767b9ac77"),
                column: "ConcurrencyStamp",
                value: "e84e3f4f-76fa-437e-a100-49d7f06b0227");
        }
    }
}
