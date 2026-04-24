/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:11
 * Version: 1.0.183
 */

using FlAdmin.Common.Models.Auth;
using Microsoft.AspNetCore.Authorization;

namespace FlAdmin.Logic.Services;

public class AdminAuthorizeAttribute : AuthorizeAttribute
{
    public AdminAuthorizeAttribute(params Role[] roles)
    {
        Roles = $"{string.Join(",", roles.Distinct().Select(x => x.ToString()))}, {Role.SuperAdmin}";
    }
}