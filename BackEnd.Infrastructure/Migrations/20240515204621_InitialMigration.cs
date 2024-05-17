using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Debtors",
                columns: table => new
                {
                    DebtorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessedIncome = table.Column<int>(type: "int", nullable: false),
                    BalanceOfDebt = table.Column<int>(type: "int", nullable: false),
                    Complaints = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debtors", x => x.DebtorId);
                });

            migrationBuilder.InsertData(
                table: "Debtors",
                columns: new[] { "DebtorId", "Address", "AssessedIncome", "BalanceOfDebt", "Complaints", "FirstName", "LastName", "SSN" },
                values: new object[,]
                {
                    { 1, "09 Westend Terrace", 60668, 11585, true, "Supun", "Priyamantha", "424-11-9327" },
                    { 2, "04 Eastend Terrace", 78968, 11543, true, "Sandun", "Lasantha", "424-11-9323" },
                    { 3, "04 North London", 85245, 10258, false, "Kasun", "Shanaka", "424-11-4717" },
                    { 4, "04 North Wellington", 96587, 20147, true, "Roy", "Dias", "424-12-7896" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Debtors");
        }
    }
}
