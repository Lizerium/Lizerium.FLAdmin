/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

using System.Security.Claims;

namespace FlAdmin.Common.Auth;

public interface IJwtProvider
{
    string GenerateToken(ClaimsIdentity identity);
    string? DecryptToken(string token);
}