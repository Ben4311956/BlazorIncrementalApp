using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorIncrementalApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buttons",
                columns: table => new
                {
                    ButtonsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MidPointBtnUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    HighPointBtnUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    CriticalGainUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    AutoClickerUnlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buttons", x => x.ButtonsID);
                });

            migrationBuilder.CreateTable(
                name: "MindoorOres",
                columns: table => new
                {
                    MindoorOresID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IronOre = table.Column<int>(type: "int", nullable: false),
                    IronOreUnlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MindoorOres", x => x.MindoorOresID);
                });

            migrationBuilder.CreateTable(
                name: "MoonPoints",
                columns: table => new
                {
                    MoonPointsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoonPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlanetsUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    MoonUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    VenusUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    MindoorUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    TotalMindoorMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalVenusMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoonPoints", x => x.MoonPointsID);
                });

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    PointsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Point = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BasePoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Upgrades = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Upgrade2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Upgrade2Unlocked = table.Column<bool>(type: "bit", nullable: false),
                    Upgrade3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Upgrade3Unlocked = table.Column<bool>(type: "bit", nullable: false),
                    Upgrade4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Upgrade4Unlocked = table.Column<bool>(type: "bit", nullable: false),
                    Upgrade5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Upgrade5Unlocked = table.Column<bool>(type: "bit", nullable: false),
                    CriticalBoost = table.Column<double>(type: "float", nullable: false),
                    CriticalGainAmount = table.Column<int>(type: "int", nullable: false),
                    CriticalGainChance = table.Column<double>(type: "float", nullable: false),
                    OverdoseUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    Overdose = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OverdoseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DelayAmount = table.Column<int>(type: "int", nullable: false),
                    AutoClickerUpgrades = table.Column<int>(type: "int", nullable: false),
                    Pet1 = table.Column<bool>(type: "bit", nullable: false),
                    Pet1Boost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pet1Equipped = table.Column<bool>(type: "bit", nullable: false),
                    Pet2 = table.Column<bool>(type: "bit", nullable: false),
                    Pet2Boost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pet2Equipped = table.Column<bool>(type: "bit", nullable: false),
                    Pet3 = table.Column<bool>(type: "bit", nullable: false),
                    Pet3Boost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pet3Equipped = table.Column<bool>(type: "bit", nullable: false),
                    Pet4 = table.Column<bool>(type: "bit", nullable: false),
                    Pet4Boost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pet4Equipped = table.Column<bool>(type: "bit", nullable: false),
                    Pet5 = table.Column<bool>(type: "bit", nullable: false),
                    Pet5Boost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pet5Equipped = table.Column<bool>(type: "bit", nullable: false),
                    PetsEquipped = table.Column<int>(type: "int", nullable: false),
                    Prestige = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrestigeUnlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.PointsID);
                });

            migrationBuilder.CreateTable(
                name: "VenusPoints",
                columns: table => new
                {
                    VenusPointsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crysallite = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MineLevel = table.Column<int>(type: "int", nullable: false),
                    MineCost = table.Column<int>(type: "int", nullable: false),
                    AutoDrillBoost = table.Column<int>(type: "int", nullable: false),
                    AutoDrillUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    LaserMinerUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    LaserMinerBoost = table.Column<int>(type: "int", nullable: false),
                    QuantumExtractorUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    Crysalline = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenusPoints", x => x.VenusPointsID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buttons");

            migrationBuilder.DropTable(
                name: "MindoorOres");

            migrationBuilder.DropTable(
                name: "MoonPoints");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "VenusPoints");
        }
    }
}
