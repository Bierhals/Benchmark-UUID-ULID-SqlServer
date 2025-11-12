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
                name: "DataKeyUuidV7BinaryBigEndians",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "binary(16)", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7BinaryBigEndians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7CIs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7CIs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7NCIBinarys",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "binary(16)", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7NCIBinarys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7NCIs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7NCIs", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
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
                name: "DataKeyUuidV7BinaryBigEndianDetails",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "binary(16)", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV7BinaryBigEndianId = table.Column<byte[]>(type: "binary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7BinaryBigEndianDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV7BinaryBigEndianDetails_DataKeyUuidV7BinaryBigEndians_DataKeyUuidV7BinaryBigEndianId",
                        column: x => x.DataKeyUuidV7BinaryBigEndianId,
                        principalTable: "DataKeyUuidV7BinaryBigEndians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7CIDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV7CIId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7CIDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV7CIDetails_DataKeyUuidV7CIs_DataKeyUuidV7CIId",
                        column: x => x.DataKeyUuidV7CIId,
                        principalTable: "DataKeyUuidV7CIs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7NCIBinaryDetails",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "binary(16)", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV7NCIBinaryId = table.Column<byte[]>(type: "binary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7NCIBinaryDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV7NCIBinaryDetails_DataKeyUuidV7NCIBinarys_DataKeyUuidV7NCIBinaryId",
                        column: x => x.DataKeyUuidV7NCIBinaryId,
                        principalTable: "DataKeyUuidV7NCIBinarys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKeyUuidV7NCIDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data1 = table.Column<int>(type: "int", nullable: false),
                    Data2 = table.Column<int>(type: "int", nullable: false),
                    DataKeyUuidV7NCIId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKeyUuidV7NCIDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_DataKeyUuidV7NCIDetails_DataKeyUuidV7NCIs_DataKeyUuidV7NCIId",
                        column: x => x.DataKeyUuidV7NCIId,
                        principalTable: "DataKeyUuidV7NCIs",
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
                name: "IX_DataKeyUuidV7BinaryBigEndianDetails_DataKeyUuidV7BinaryBigEndianId",
                table: "DataKeyUuidV7BinaryBigEndianDetails",
                column: "DataKeyUuidV7BinaryBigEndianId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUuidV7CIDetails_DataKeyUuidV7CIId",
                table: "DataKeyUuidV7CIDetails",
                column: "DataKeyUuidV7CIId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUuidV7NCIBinaryDetails_DataKeyUuidV7NCIBinaryId",
                table: "DataKeyUuidV7NCIBinaryDetails",
                column: "DataKeyUuidV7NCIBinaryId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKeyUuidV7NCIDetails_DataKeyUuidV7NCIId",
                table: "DataKeyUuidV7NCIDetails",
                column: "DataKeyUuidV7NCIId");

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
                name: "DataKeyUuidV7BinaryBigEndianDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7CIDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7NCIBinaryDetails");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7NCIDetails");

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
                name: "DataKeyUuidV7BinaryBigEndians");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7CIs");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7NCIBinarys");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7NCIs");

            migrationBuilder.DropTable(
                name: "DataKeyUuidV7Texts");
        }
    }
}
