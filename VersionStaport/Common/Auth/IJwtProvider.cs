/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

using System.Security.Claims;

namespace FlAdmin.Common.Auth;

public interface IJwtProvider
{
    string GenerateToken(ClaimsIdentity identity);
    string? DecryptToken(string token);
}