/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

namespace Common.Auth;
using System.Security.Claims;

public interface IJwtProvider
{
	string GenerateToken(ClaimsIdentity identity);
	string? DecryptToken(string token);
}
