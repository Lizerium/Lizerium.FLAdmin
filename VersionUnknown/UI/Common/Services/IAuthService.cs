/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

using LanguageExt;

namespace FlAdmin.Common.Services;

public interface IAuthService
{
    public Task<Option<string>> Authenticate(string username, string password);
}