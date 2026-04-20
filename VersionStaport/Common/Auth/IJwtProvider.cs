/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

using System.Security.Claims;

namespace FlAdmin.Common.Auth;

public interface IJwtProvider
{
    string GenerateToken(ClaimsIdentity identity);
    string? DecryptToken(string token);
}