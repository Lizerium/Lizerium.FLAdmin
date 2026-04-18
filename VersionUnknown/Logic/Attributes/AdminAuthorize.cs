/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Logic.Attributes;

using Common.Auth;
using Microsoft.AspNetCore.Authorization;

public class AdminAuthorizeAttribute : AuthorizeAttribute
{
	public AdminAuthorizeAttribute(params Role[] roles) => Roles = $"{string.Join(",", roles.Distinct().Select(x => x.ToString()))}, {Role.InstanceAdmin}";
}
