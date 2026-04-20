/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

namespace FlAdmin.Common.Models.Auth;

public enum Role : uint
{
    Web,
    Game,
    ManageAdmins,
    ManageAutomation,
    ManageAccounts,
    ManageServer,
    SuperAdmin, // Essentially has all roles.
    ManageRoles,
    Database,
    User //Default role, basically anything that has a password will have this role.
}