/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
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