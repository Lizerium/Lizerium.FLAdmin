/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

namespace Common.Auth;
using System.Security.Claims;

public interface IJwtProvider
{
	string GenerateToken(ClaimsIdentity identity);
	string? DecryptToken(string token);
}
