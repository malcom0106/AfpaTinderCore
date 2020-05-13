using Microsoft.EntityFrameworkCore.Migrations;

namespace AfpaTinderCore.Data.Migrations
{
    public partial class miseajourpersonne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Personnes",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Personnes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Personnes",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Enfants",
                table: "Personnes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAppliMobile",
                table: "Personnes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsGeoloc",
                table: "Personnes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Personnes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Personnes",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Personnes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Personnes",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prenom",
                table: "Personnes",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Statut",
                table: "Personnes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Personnes",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Enfants",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "IsAppliMobile",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "IsGeoloc",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Prenom",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Statut",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Personnes");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Personnes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
