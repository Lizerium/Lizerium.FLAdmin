/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
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