/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Common.Auth;
using System.Security.Claims;

public interface IJwtProvider
{
	string GenerateToken(ClaimsIdentity identity);
	string? DecryptToken(string token);
}
