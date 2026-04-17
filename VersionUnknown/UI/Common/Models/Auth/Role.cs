/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
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