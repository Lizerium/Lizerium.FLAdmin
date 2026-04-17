/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

using LanguageExt;

namespace FlAdmin.Common.Services;

public interface IAuthService
{
    public Task<Option<string>> Authenticate(string username, string password, CancellationToken token);
}