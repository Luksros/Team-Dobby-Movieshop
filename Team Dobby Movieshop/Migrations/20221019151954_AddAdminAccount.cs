using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace Team_Dobby_Movieshop.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        //USED TO CREATE A USER, ADMIN ROLE AND CONNECT THEM

        const string ADMIN_USER_GUID = "9cbd3cf4-4fc7-11ed-bdc3-0242ac120002";
        const string ADMIN_ROLE_GUID = "a131739a-4fc7-11ed-bdc3-0242ac120002";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var passwordHash = hasher.HashPassword(null, "Password100!");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName, Email, EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, NormalizedEmail, PasswordHash, SecurityStamp)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{ADMIN_USER_GUID}'");
            sb.AppendLine(",'admin@svensson.se'");
            sb.AppendLine(",'ADMIN@SVENSSON.SE'");
            sb.AppendLine(",'admin@svensson.se'");
            sb.AppendLine(",0");
            sb.AppendLine(",0");
            sb.AppendLine(",0");
            sb.AppendLine(",0");
            sb.AppendLine(",0");
            sb.AppendLine(",'ADMIN@SVENSSON.SE'");
            sb.AppendLine($",'{passwordHash}'");
            sb.AppendLine(",''");
            //sb.AppendLine(",'Admin'");
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());
            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{ADMIN_ROLE_GUID}','Admin','ADMIN')");
            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{ADMIN_USER_GUID}','{ADMIN_ROLE_GUID}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId ='{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");
            migrationBuilder.Sql($"DELETE FROM AspNetUser WHERE Id ='{ADMIN_USER_GUID}'");
            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id ='{ADMIN_ROLE_GUID}'");
        }
    }
}
