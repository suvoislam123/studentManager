using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManager.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One" },
                    { 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two" },
                    { 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three" },
                    { 4, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Four" },
                    { 5, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Five" },
                    { 6, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Six" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "CreatedDate", "DOB", "GenderId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("00e6c5e2-6a1d-47af-9b99-30429969ae22"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("041d36e4-7e03-43a1-a3e1-044d0104e32b"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("05b3091b-2715-40bc-8759-fd70ab5d1712"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("0913e802-96bc-4223-880f-a549d93aee75"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("092cd5e9-a4ac-4985-9f06-3315e347c46d"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("0a629715-0828-42e8-b7a4-0acb9c58dbf8"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("11e301e0-31bd-430f-9e72-fc91f878adc1"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("1bfb4dcc-9a18-41f8-909a-31597114625e"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("1fff6898-69dc-4c62-ab7a-7059913406c2"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("29a8978a-19e4-46d1-a78d-bfdfb6abd76f"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("2a46bf34-3f3c-425f-8035-972b129b7368"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("2dd00934-93fe-4a25-ad0b-c34754577a89"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("30338284-1163-49ed-a7a0-3ff928c8d247"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("36b15cd9-f89b-4eed-9ea7-f7762b7987fe"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("3c92ea87-4e93-4032-8bc6-635b7f0e3f77"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("3e59c093-65f1-49e1-8922-34fd823c42cf"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("3f688c1f-044e-48fd-a0bd-565559dcc798"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("3ffc986c-7ac0-4da4-a3ff-4f689c532f70"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("40404935-088c-4c46-a9a0-361eccace7c4"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("42bc6b41-0f6b-4be6-a8d4-3c179155ce6d"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("4627cdda-6498-4d1a-9c06-149bfc5d1414"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("490a27a8-bc07-4fd6-8894-873aa434cae8"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("4af7d7ec-78db-447d-be31-bf7a11cce1bc"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("51478f19-0de2-4864-aa12-48b2237ed57e"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("52b06b93-e340-4cec-a10f-d1f155b05796"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("5424cc7b-2258-4ea8-be24-002453651e32"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("59b5f8e2-38fd-4330-80bf-3f80a2b9fc3f"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("5bb7b4a2-a1f5-433e-8bde-ff67ea2f7c0a"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("622c269a-9a2d-4321-b9d2-e2836b28bcae"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("65837564-6067-4775-8fe3-0226ac8d0b81"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("6ceeadfb-e04c-4cf7-b116-6e7753717d75"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("7091cdf1-fcf3-48c1-a16d-0ad208572367"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("73bc7841-724b-4dfe-ba7d-ae01ff4bda52"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("7456c206-30ad-41b5-b3bd-ca1b5d737796"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("7925d26b-1474-49f1-9d13-1e4371475f12"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("7c6c2540-6ee8-4517-8dbb-f46176b609d0"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("7ce040fa-0e23-48ce-86ce-f62335cf3b70"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("7dc3e1a7-1926-4867-8325-bec697faa84e"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("7de92eca-1603-4cb4-a27e-fbd91a380fed"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("864dbfa5-0be9-4662-b2bc-0dc7f47aab18"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("86a754ad-bf76-4833-ab14-209ac3237307"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("8900cdac-5205-494f-a96e-630b63025c87"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("898f0f62-36a6-413b-b6e2-4e5a69a64ff6"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("8d5dd87e-3629-42b8-98cd-8ee25e5fe8a0"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("8fd15520-84b7-4094-913a-8210769fb4fc"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("a462702b-3080-4296-9ba9-43febb8557c1"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("a47b8a4c-eb9b-4757-a3a7-d7f3f3e7e5f9"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("a4cc24b1-5a3e-4ad6-ae9d-a39a6fafadf3"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("a8e62d10-c2fe-4119-86d4-9844013d970f"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("ac3be9a7-2fce-430c-a7ba-5e044e586bb1"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("b1559dad-e746-4783-b656-e8e0da3f6346"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("b50c8472-a8d8-4147-9658-fe62d0090bb6"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("b6f8d8cd-7e22-4b10-ae39-88f3b87fe319"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("b97bdf1f-6a2f-4e32-83df-dbfb4b4603d7"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("ba0cbb8b-2a7f-460b-b6c5-abffaf9b691f"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("bafb8905-92f0-4bfa-a217-044d6d3dc816"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("be0ac64e-5193-4b4a-a167-37c51a0d6c31"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("c4d347cf-ad91-4a0c-a4a0-da7b7cbebb28"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("c7b7ddf8-11c7-4ea3-bfa7-14607a3cc788"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("c835cefe-679d-4d5a-8bb2-2b5bf5c9a43b"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("cc0d45d1-d40c-49c3-b455-035836563395"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("d105cb46-98f9-4e87-94db-9e45ce0d26ec"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("d25f747d-1300-47c8-bb9b-e7e4b32ced26"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("d62dea9a-b1f8-4099-8d60-a3fea409be6c"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("dc9b8562-c7b8-4365-a16c-afcfaf215e07"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("de95e2c8-58e5-432b-ab55-b2ef82768a03"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("dee31b64-e576-475b-ac9c-a7ccb3df2969"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("df78669b-a9fa-440a-bc1e-557f15a64fc4"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("e03f5bf6-fc0b-4255-a009-d30f22bae224"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("e7117431-7a6c-4370-8360-ef361a9d5db1"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("e713a4c2-b77c-4051-917b-dc6d8f01cb3e"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("e81a3276-0a78-41b5-aaf7-6cebad0c761a"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("e8a6e755-0e54-4e07-a76a-0545250da1a4"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Sahabuddin Sheikh" },
                    { new Guid("ec581a1f-1994-43be-a9d1-9d59c46f9c80"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("eecd6013-e4f4-4fab-b14d-5204160c46be"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" },
                    { new Guid("eeeab530-bc97-4bf4-9463-6142575c3b83"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("f3aa01ff-34d2-40b1-a302-49278b610649"), 3, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2003, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Shawon Sheikh" },
                    { new Guid("f49f0e83-e1d8-4f75-9ded-1c66b75505a6"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("f5cf238a-cbe3-407e-a51a-8742f9bcf2a3"), 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Shuvo Islam" },
                    { new Guid("f9cfea73-8402-482d-8f9b-8c37d6a8cc49"), 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Shaiful Sheikh" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderId",
                table: "Students",
                column: "GenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
