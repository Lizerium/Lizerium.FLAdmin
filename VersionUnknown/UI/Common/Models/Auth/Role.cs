/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

namespace FlAdmin.Common.Models.Auth;

public enum Role : uint
{
    Web,
    ManageAdmins,
    ManageAutomation,
    ManageAccounts,
    ManageServer,
    SuperAdmin, // Essentially has all roles.
    ManageRoles
}