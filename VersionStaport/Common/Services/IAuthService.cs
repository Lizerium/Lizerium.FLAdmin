/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using LanguageExt;

namespace FlAdmin.Common.Services;

public interface IAuthService
{
    public Task<Option<string>> Authenticate(string username, string password, CancellationToken token);
}