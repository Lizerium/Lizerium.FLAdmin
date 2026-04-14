/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

using System.Security.Claims;

namespace FlAdmin.Common.Auth;

public interface IJwtProvider
{
    string GenerateToken(ClaimsIdentity identity);
    string? DecryptToken(string token);
}