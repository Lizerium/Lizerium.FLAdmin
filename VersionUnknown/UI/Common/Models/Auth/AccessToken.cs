/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

namespace FlAdmin.Common.Models.Auth;

public class AccessToken
{
    public AccessToken(string token, string userName, List<Role> roles)
    {
        Token = token;
        UserName = userName;
        Roles = roles;
    }

    public string Token { get; set; }
    public string UserName { get; set; }
    private List<Role> Roles { get; set; }
}