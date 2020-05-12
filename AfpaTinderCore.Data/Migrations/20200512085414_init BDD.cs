using Microsoft.EntityFrameworkCore.Migrations;

namespace AfpaTinderCore.Data.Migrations
{
    public partial class initBDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Statut = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loisirs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(maxLength: 50, nullable: false),
                    Statut = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loisirs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrientationSexuelles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Statut = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrientationSexuelles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SituationFamiliales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Statut = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituationFamiliales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeRelations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Statut = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeRelations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(maxLength: 100, nullable: true),
                    AllureId = table.Column<int>(nullable: true),
                    OrientationSexuelleId = table.Column<int>(nullable: true),
                    TypeRelationId = table.Column<int>(nullable: true),
                    SituationFamilialeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnes_Allure_AllureId",
                        column: x => x.AllureId,
                        principalTable: "Allure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnes_OrientationSexuelles_OrientationSexuelleId",
                        column: x => x.OrientationSexuelleId,
                        principalTable: "OrientationSexuelles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnes_SituationFamiliales_SituationFamilialeId",
                        column: x => x.SituationFamilialeId,
                        principalTable: "SituationFamiliales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnes_TypeRelations_TypeRelationId",
                        column: x => x.TypeRelationId,
                        principalTable: "TypeRelations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonneId = table.Column<int>(nullable: false),
                    FavoriPersonneId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favori_Personnes_FavoriPersonneId",
                        column: x => x.FavoriPersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Favori_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonneLoisirs",
                columns: table => new
                {
                    LoisirId = table.Column<int>(nullable: false),
                    PersonneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonneLoisirs", x => new { x.PersonneId, x.LoisirId });
                    table.ForeignKey(
                        name: "FK_PersonneLoisirs_Loisirs_LoisirId",
                        column: x => x.LoisirId,
                        principalTable: "Loisirs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonneLoisirs_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favori_FavoriPersonneId",
                table: "Favori",
                column: "FavoriPersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Favori_PersonneId",
                table: "Favori",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonneLoisirs_LoisirId",
                table: "PersonneLoisirs",
                column: "LoisirId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_AllureId",
                table: "Personnes",
                column: "AllureId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_OrientationSexuelleId",
                table: "Personnes",
                column: "OrientationSexuelleId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_SituationFamilialeId",
                table: "Personnes",
                column: "SituationFamilialeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_TypeRelationId",
                table: "Personnes",
                column: "TypeRelationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favori");

            migrationBuilder.DropTable(
                name: "PersonneLoisirs");

            migrationBuilder.DropTable(
                name: "Loisirs");

            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "Allure");

            migrationBuilder.DropTable(
                name: "OrientationSexuelles");

            migrationBuilder.DropTable(
                name: "SituationFamiliales");

            migrationBuilder.DropTable(
                name: "TypeRelations");
        }
    }
}
