/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

using System.Security.Claims;
using FlAdmin.Common.Auth;
using FlAdmin.Common.Services;
using LanguageExt;
using Microsoft.Extensions.Logging;

namespace FlAdmin.Logic.Services.Auth;

public class AuthService(IJwtProvider jwtProvider, IAccountService accountService, ILogger<AuthService> logger)
    : IAuthService
{
    private readonly ILogger<AuthService> _logger = logger;

    public async Task<Option<string>> Authenticate(string username, string password)
    {
        var account = await accountService.GetAccountByUserName(username);
        return account.Match<Option<string>>(
            Left: error => new Option<string>(),
            Right: val =>
            {
                if (!PasswordHasher.VerifyPassword(password, val.PasswordHash!, val.Salt!)) return new Option<string>();

                var token = jwtProvider.GenerateToken((val.ToClaimsPrincipal().Identity as ClaimsIdentity)!);
                return token;
            }
        );
    }
}