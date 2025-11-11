using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataKeyUlidBinarys",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "binary(16)", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUlidBinarys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUlidTexts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUlidTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV4CIs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV4CIs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV4NCIs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV4NCIs", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7Binarys",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "binary(16)", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7Binarys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7s",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7Texts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(36)", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7Texts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUlidBinaryDetails",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "binary(16)", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUlidBinaryId = table.Column<byte[]>(type: "binary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUlidBinaryDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKeyUlidBinaryDetails_DataKeyUlidBinarys_DataKeyUlidBinaryId",
                        column: x => x.DataKeyUlidBinaryId,
                        principalTable: "DataKeyUlidBinarys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUlidTextDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUlidTextId = table.Column<string>(type: "char(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUlidTextDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKeyUlidTextDetails_DataKeyUlidTexts_DataKeyUlidTextId",
                        column: x => x.DataKeyUlidTextId,
                        principalTable: "DataKeyUlidTexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV4CIDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV4CIId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV4CIDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV4CIDetails_DataKeyUuidV4CIs_DataKeyUuidV4CIId",
                        column: x => x.DataKeyUuidV4CIId,
                        principalTable: "DataKeyUuidV4CIs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV4NCIDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV4NCIId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV4NCIDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV4NCIDetails_DataKeyUuidV4NCIs_DataKeyUuidV4NCIId",
                        column: x => x.DataKeyUuidV4NCIId,
                        principalTable: "DataKeyUuidV4NCIs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7BinaryDetails",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "binary(16)", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV7BinaryId = table.Column<byte[]>(type: "binary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7BinaryDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV7BinaryDetails_DataKeyUuidV7Binarys_DataKeyUuidV7BinaryId",
                        column: x => x.DataKeyUuidV7BinaryId,
                        principalTable: "DataKeyUuidV7Binarys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV7Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV7Details_DataKeyUuidV7s_DataKeyUuidV7Id",
                        column: x => x.DataKeyUuidV7Id,
                        principalTable: "DataKeyUuidV7s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7TextDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(36)", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV7TextId = table.Column<string>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7TextDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV7TextDetails_DataKeyUuidV7Texts_DataKeyUuidV7TextId",
                        column: x => x.DataKeyUuidV7TextId,
                        principalTable: "DataKeyUuidV7Texts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUlidBinaryDetails_DataKeyUlidBinaryId",
                table: "DataKeyUlidBinaryDetails",
                column: "DataKeyUlidBinaryId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUlidTextDetails_DataKeyUlidTextId",
                table: "DataKeyUlidTextDetails",
                column: "DataKeyUlidTextId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUuidV4CIDetails_DataKeyUuidV4CIId",
                table: "DataKeyUuidV4CIDetails",
                column: "DataKeyUuidV4CIId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUuidV4NCIDetails_DataKeyUuidV4NCIId",
                table: "DataKeyUuidV4NCIDetails",
                column: "DataKeyUuidV4NCIId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUuidV7BinaryDetails_DataKeyUuidV7BinaryId",
                table: "DataKeyUuidV7BinaryDetails",
                column: "DataKeyUuidV7BinaryId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUuidV7Details_DataKeyUuidV7Id",
                table: "DataKeyUuidV7Details",
                column: "DataKeyUuidV7Id");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUuidV7TextDetails_DataKeyUuidV7TextId",
                table: "DataKeyUuidV7TextDetails",
                column: "DataKeyUuidV7TextId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataKeyUlidBinaryDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUlidTextDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV4CIDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV4NCIDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7BinaryDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7Details");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7TextDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUlidBinarys");

            migrationBuilder.DropTable(
                name: "DataKeyUlidTexts");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV4CIs");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV4NCIs");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7Binarys");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7s");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7Texts");
        }
    }
}
