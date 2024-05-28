using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutorZealand.Migrations
{
    /// <inheritdoc />
    public partial class NullableRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Rooms",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "EducationId", "File", "StudentId" },
                values: new object[] { 1, 1, "[0,2,3,45,5,1,2]", 1 });

            migrationBuilder.InsertData(
                table: "AssistantTeachers",
                columns: new[] { "Id", "Description", "EducationId", "Email", "Name", "Telephone" },
                values: new object[,]
                {
                    { 1, "Jeg hedder ole", 1, "ole@zealand.dk", "Ole Jensen", "22331122" },
                    { 2, "Jeg hedder Frank og elsker frankurt", 1, "frank@zealand.dk", "Frank Frankfurter", "33551122" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "SessionId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Datamatiker" },
                    { 2, "Multimedie designer" },
                    { 3, "Finansøkonom" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Roskilde Campus" },
                    { 2, "Næstved Campus" },
                    { 3, "København Campus" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "1A" },
                    { 2, 1, "2A" },
                    { 3, 1, "3A" },
                    { 4, 2, "1B" },
                    { 5, 2, "2B" },
                    { 6, 2, "3B" },
                    { 7, 3, "1C" },
                    { 8, 3, "2C" },
                    { 9, 3, "3C" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "AssistantTeacherId", "Description", "EducationId", "EndDate", "IsActive", "LocationId", "RoomId", "StartDate", "SubjectId" },
                values: new object[] { 1, 1, "Vi skal lære om basale programmerings ting sammen med mig, Ole Jensen.", 1, new DateTime(2024, 5, 29, 23, 29, 52, 917, DateTimeKind.Local).AddTicks(8547), true, 1, 1, new DateTime(2024, 5, 29, 22, 29, 52, 917, DateTimeKind.Local).AddTicks(8503), 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EducationId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 1, "mert@zealand.dk", "Mert Gultekin" },
                    { 2, 1, "milad@zealand.dk", "Milad Muladsen" },
                    { 3, 1, "vang@zealand.dk", "Vagn Ravn" },
                    { 4, 1, "hulle@zealand.dk", "Hulle Tullesen" },
                    { 5, 1, "jared@zealand.dk", "Jared Padelecki" },
                    { 6, 1, "jensen@zealand.dk", "Jensen Ackles" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssistantTeachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssistantTeachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Rooms",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
